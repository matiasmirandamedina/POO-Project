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
                MessageBox.Show($"Cotizaciones de hoy:\n\n" +
                                $"Dólar oficial:\nCompra: {dolar.compra:F2} | Venta: {dolar.venta:F2}\n\n" +
                                $"Euro oficial:\nCompra: {euro.compra:F2} | Venta: {euro.venta:F2}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la cotización del dólar/euro: " + ex.Message);
            }
        }

        private async void transferir_Click(object sender, EventArgs e)
        {
            try
            {
                string account_origin = radioAlias.Checked ? comboBox1.Text : comboBox2.Text;
                string account_destination = this.cuentaDestino.Text;
                string amountText = this.monto.Text;

                account_origin = account_origin.Trim().ToLower();
                account_destination = account_destination.Trim().ToLower();

                decimal saldo = 0;
                Account cuentaOrigenObj = null;
                Account cuentaDestinoObj = null;

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
                    if (account.Get_Cbu().ToLower() == account_origin || account.Get_Alias().ToLower() == account_origin)
                    {
                        cuentaOrigenObj = account;
                        saldo = account.Get_Saldo();
                    }
                }

                if (cuentaOrigenObj == null)
                    throw new Own_Exception("Cuenta de origen no encontrada.");
                
                if (cuentaOrigenObj.Tipo == "Cuenta Ahorro")
                {
                    if (saldo < amount)
                        throw new Own_Exception($"El monto seleccionado supera el actual. Ingrese un monto igual o menor a {saldo}");
                }
                else if (cuentaOrigenObj.Tipo == "Cuenta Corriente")
                {
                    if (cuentaOrigenObj.monedaId == 1 && (saldo - amount) < -20)
                        throw new Own_Exception("Llego al saldo negativo en USD permitido. Para continuar, ingrese dinero.");
                    if (cuentaOrigenObj.monedaId == 2 && (saldo - amount) < -25000)
                        throw new Own_Exception("Llego al saldo negativo en ARS permitido. Para continuar, ingrese dinero.");
                    if (cuentaOrigenObj.monedaId == 3 && (saldo - amount) < -15)
                        throw new Own_Exception("Llego al saldo negativo en EUR permitido. Para continuar, ingrese dinero.");
                }

                if (cuentaDestinoObj == null)
                {
                    string query = @"SELECT a.id, at.description, a.currency_id, a.alias, a.current_balance, a.cbu FROM accounts a JOIN account_types at ON a.account_type_id = at.id WHERE a.alias = @dest OR a.cbu = @dest LIMIT 1;";

                    using (var cmd = new MySqlCommand(query, mConexion.getConexion()))
                    {
                        cmd.Parameters.AddWithValue("@dest", account_destination);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                cuentaDestinoObj = new Account(Convert.ToInt32(reader["id"]), reader["alias"].ToString(), reader["description"].ToString(), Convert.ToDecimal(reader["current_balance"]), reader["cbu"].ToString(), Convert.ToInt32(reader["currency_id"]));
                            }
                            else
                                throw new Own_Exception("Cuenta de origen no encontrada.");
                        }
                    }
                }

                decimal amountSecundario = 0;

                if (cuentaOrigenObj.monedaId == 1)
                {
                    if (cuentaDestinoObj.monedaId == 1)
                        amountSecundario = amount;

                    if (cuentaDestinoObj.monedaId == 2)
                        amountSecundario = await DolarAPeso(amount);

                    if (cuentaDestinoObj.monedaId == 3)
                        amountSecundario = await DolarAEuro(amount);
                }

                if (cuentaOrigenObj.monedaId == 2)
                {
                    if (cuentaDestinoObj.monedaId == 1)
                        amountSecundario = await PesoADolar(amount);

                    if (cuentaDestinoObj.monedaId == 2)
                        amountSecundario = amount;

                    if (cuentaDestinoObj.monedaId == 3)
                        amountSecundario = await PesoAEuro(amount);
                }

                if (cuentaOrigenObj.monedaId == 3)
                {
                    if (cuentaDestinoObj.monedaId == 1)
                        amountSecundario = await EuroADolar(amount);

                    if (cuentaDestinoObj.monedaId == 2)
                        amountSecundario = await EuroAPeso(amount);

                    if (cuentaDestinoObj.monedaId == 3)
                        amountSecundario = amount;
                }

                if (amount <= 0) throw new Own_Exception($"El monto seleccionado no puede ser igual o menor a cero");

                string transaction = "INSERT INTO transactions (account_id, destination_account_id, type, amount, currency_id, description, created_by, created_at) VALUES (@cuentaOrigen, @cuentaDestino, 'DEBITO', @montoDecimal, 2, 'Pago de servicios', 2, NOW());";
                string discount = "UPDATE accounts SET current_balance = current_balance - @montoDecimal WHERE id = @cuentaOrigen;";
                string add = "UPDATE accounts SET current_balance = current_balance + @montoDecimal WHERE id = @cuentaDestino;";



                if (mConexion.getConexion() != null)
                {
                    using (MySqlCommand log = new MySqlCommand(transaction, mConexion.getConexion()))
                    {
                        log.Parameters.AddWithValue("@cuentaOrigen", cuentaOrigenObj.Id);
                        log.Parameters.AddWithValue("@cuentaDestino", cuentaDestinoObj.Id);
                        log.Parameters.AddWithValue("@montoDecimal", amount);
                        log.ExecuteNonQuery();
                    }

                    using (MySqlCommand cmd_discount = new MySqlCommand(discount, mConexion.getConexion()))
                    {
                        cmd_discount.Parameters.AddWithValue("@montoDecimal", amount);
                        cmd_discount.Parameters.AddWithValue("@cuentaOrigen", cuentaOrigenObj.Id);
                        cmd_discount.ExecuteNonQuery();
                    }

                    using (MySqlCommand cmd_add = new MySqlCommand(add, mConexion.getConexion()))
                    {
                        cmd_add.Parameters.AddWithValue("@montoDecimal", amountSecundario);
                        cmd_add.Parameters.AddWithValue("@cuentaDestino", cuentaDestinoObj.Id);
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

        private async Task<decimal> DolarAEuro(decimal monto)
        {
            var dolar = await ObtenerDolarOficial();
            var euro = await ObtenerEuroOficial();

            decimal valorDolar = dolar.compra;
            decimal valorEuro = euro.venta;
            return monto * (valorDolar / valorEuro);
        }

        private async Task<decimal> EuroADolar(decimal monto)
        {
            var euro = await ObtenerEuroOficial();
            var dolar = await ObtenerDolarOficial();

            decimal valorEuro = euro.compra;
            decimal valorDolar = dolar.venta;
            return monto * (valorEuro / valorDolar);
        }

        private async Task<decimal> PesoADolar(decimal monto)
        {
            var dolar = await ObtenerDolarOficial();
            return monto / dolar.venta;
        }

        private async Task<decimal> DolarAPeso(decimal monto)
        {
            var dolar = await ObtenerDolarOficial();
            return monto * dolar.compra;
        }

        private async Task<decimal> PesoAEuro(decimal monto)
        {
            var euro = await ObtenerEuroOficial();
            return monto / euro.venta;
        }

        private async Task<decimal> EuroAPeso(decimal monto)
        {
            var euro = await ObtenerEuroOficial();
            return monto * euro.compra;
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