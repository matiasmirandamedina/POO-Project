using mini_home_banking.Controladores;
using mini_home_banking.Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace mini_home_banking.Vistas
{
    public partial class Transferencia : Form
    {
        private Conexion mConexion;
        private List<Account> accounts;

        public Transferencia(List<Account> accounts)
        {
            InitializeComponent();
            this.accounts = accounts;
            mConexion = new Conexion();
        }
        private async Task<currency> ObtenerDolarOficial()
        {
            string url = "https://dolarapi.com/v1/dolares/oficial";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string json = await response.Content.ReadAsStringAsync();

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                return JsonSerializer.Deserialize<currency>(json, options);
            }
        }

        private async Task<currency> ObtenerEuroOficial()
        {
            string url = "https://dolarapi.com/v1/cotizaciones/eur";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string json = await response.Content.ReadAsStringAsync();

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                return JsonSerializer.Deserialize<currency>(json, options);
            }
        }

        // dolar a euro: dividir el valor del dolar por el del euro
        // euro a dolar: dividir el valor del euro por el del dolar

        private async void Transferencia_Load(object sender, EventArgs e)
        {
            List<string> aliases = accounts.Select(a => a.Get_Alias()).ToList();
            List<string> cbus = accounts.Select(a => a.Get_Cbu()).ToList();

            comboBox1.DataSource = aliases;
            comboBox2.DataSource = cbus;

            radioAlias.CheckedChanged += (s, ev) =>
            {
                comboBox1.Enabled = radioAlias.Checked;
                comboBox2.Enabled = !radioAlias.Checked;
            };      

            radioCbu.CheckedChanged += (s, ev) =>
            {
                comboBox2.Enabled = radioCbu.Checked;
                comboBox1.Enabled = !radioCbu.Checked;
            };

            try
            {
                var dolar = await ObtenerDolarOficial();
                var euro = await ObtenerEuroOficial();
                MessageBox.Show($"Dólar oficial hoy:\nCompra: {dolar.compra.ToString("F2")}\nVenta: {dolar.venta.ToString("F2")}");
                MessageBox.Show($"Euro oficial hoy:\nCompra: {euro.compra.ToString("F2")}\nVenta: {euro.venta.ToString("F2")}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la cotización del dólar/euro: " + ex.Message);
            }
        }

        private void transferir_Click(object sender, EventArgs e)
        {
            try
            {
                string account_origin = radioAlias.Checked ? comboBox1.Text : comboBox2.Text;
                string account_destination = this.cuentaDestino.Text;
                string amountText = this.monto.Text;

                decimal saldo = 0;
                Account cuentaOrigenObj = null;

                if (string.IsNullOrWhiteSpace(amountText) || string.IsNullOrWhiteSpace(account_destination))
                {
                    throw new Own_Exception("Por favor complete todos los campos");
                }

                decimal amount;
                if (!decimal.TryParse(amountText, out amount))
                {
                    throw new Own_Exception("Por favor ingrese un monto válido (solo números).");
                }
                amount = Convert.ToDecimal(amountText);

                foreach (Account account in accounts)
                {
                    if (account.Get_Cbu() == account_origin || account.Get_Alias() == account_origin)
                    {
                        saldo = account.Get_Saldo();
                        cuentaOrigenObj = account;

                        if (cuentaOrigenObj.Tipo == "Cuenta Ahorro")
                            if (saldo < amount) throw new Own_Exception($"El monto seleccionado supera el actual. Ingrese un monto igual o menor a {saldo}");

                        if (cuentaOrigenObj.Tipo == "Cuenta Corriente")
                            if ((saldo - amount) < -25000) throw new Own_Exception($"Llego al saldo negativo permitido. Para continuar, ingrese dinero.");
                    }
                }

                if (amount <= 0) throw new Own_Exception($"El monto seleccionado no puede ser igual o menor a cero");

                string transaction = "INSERT INTO transactions (account_id, destination_account_id, type, amount, currency_id, description, created_by, created_at) VALUES (@cuentaOrigen, @cuentaDestino, 'DEBITO', @montoDecimal, 2, 'Pago de servicios', 2, NOW());";
                string discount = "UPDATE accounts SET current_balance = current_balance - @montoDecimal WHERE id = @cuentaOrigen;";
                string add = "UPDATE accounts SET current_balance = current_balance + @montoDecimal WHERE id = @cuentaDestino;";

                int id_origin = 0;
                int id_destination = 0;

                string queryId = "SELECT id FROM accounts WHERE cbu = @cbu OR alias = @alias";

                using (MySqlCommand cmd = new MySqlCommand(queryId, mConexion.getConexion()))
                {
                    cmd.Parameters.AddWithValue("@cbu", account_origin);
                    cmd.Parameters.AddWithValue("@alias", account_origin);
                    using (MySqlDataReader result_origin = cmd.ExecuteReader())
                    {
                        if (result_origin.Read())
                            id_origin = result_origin.GetInt32("id");
                        else
                        {
                            MessageBox.Show("Cuenta de origen no encontrada");
                            return;
                        }
                    }
                }

                using (MySqlCommand cmd = new MySqlCommand(queryId, mConexion.getConexion()))
                {
                    cmd.Parameters.AddWithValue("@cbu", account_destination);
                    cmd.Parameters.AddWithValue("@alias", account_destination);
                    using (MySqlDataReader result_destination = cmd.ExecuteReader())
                    {
                        if (result_destination.Read())
                            id_destination = result_destination.GetInt32("id");
                        else
                        {
                            MessageBox.Show("Cuenta de destino no encontrada");
                            return;
                        }
                    }
                }

                if (id_origin == id_destination)
                {
                    throw new Own_Exception("No puedes transferirte a ti mismo.");
                }

                if (mConexion.getConexion() != null)
                {
                    using (MySqlCommand log = new MySqlCommand(transaction, mConexion.getConexion()))
                    {
                        log.Parameters.AddWithValue("@cuentaOrigen", id_origin);
                        log.Parameters.AddWithValue("@cuentaDestino", id_destination);
                        log.Parameters.AddWithValue("@montoDecimal", amount);
                        log.ExecuteNonQuery();
                    }

                    using (MySqlCommand cmd_discount = new MySqlCommand(discount, mConexion.getConexion()))
                    {
                        cmd_discount.Parameters.AddWithValue("@montoDecimal", amount);
                        cmd_discount.Parameters.AddWithValue("@cuentaOrigen", id_origin);
                        cmd_discount.ExecuteNonQuery();
                    }

                    using (MySqlCommand cmd_add = new MySqlCommand(add, mConexion.getConexion()))
                    {
                        cmd_add.Parameters.AddWithValue("@montoDecimal", amount);
                        cmd_add.Parameters.AddWithValue("@cuentaDestino", id_destination);
                        cmd_add.ExecuteNonQuery();
                    }

                    if (cuentaOrigenObj != null)
                    {
                        cuentaOrigenObj.Set_Saldo(saldo - amount);
                    }

                    MessageBox.Show($"Se ha transferido ${amount} de la cuenta {account_origin} a la cuenta {account_destination}");
                }
            }
            catch (Own_Exception ex)
            {
                MessageBox.Show(" Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Ocurrió un error: " + ex.Message);
            }

        }

        private void radioAlias_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                comboBox1.Focus();
            }
        }

        private void comboBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                cuentaDestino.Focus();
            }
        }

        private void radioCbu_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                comboBox2.Focus();
            }
        }

        private void comboBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                cuentaDestino.Focus();
            }
        }

        private void cuentaDestino_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                monto.Focus();
            }
        }

        private void monto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                transferir.Focus();
            }
        }
    }
}