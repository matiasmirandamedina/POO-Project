using Microsoft.VisualBasic.Logging;
using mini_home_banking.Controladores;
using mini_home_banking.Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void Transferencia_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = accounts;
        }

        private void transferir_Click(object sender, EventArgs e)
        {
            try
            {
                string account_origin = this.cuentaOrigen.Text;
                string account_destination = this.cuentaDestino.Text;
                string amountText = this.monto.Text;

                if (string.IsNullOrWhiteSpace(amountText) || string.IsNullOrWhiteSpace(account_destination) || string.IsNullOrWhiteSpace(account_origin))
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
                        Account accountVer = account;
                        if (accountVer.Get_Saldo() < amount) throw new Own_Exception($"El monto seleccionado supera el actual. Ingrese un monto igual o menor a {accountVer.Get_Saldo()}");
                    }
                }

                if(amount < 0 || amount == 0) throw new Own_Exception($"El monto seleccionado no puede ser igual o menor a cero");

                string transaction = "INSERT INTO transactions (account_id, destination_account_id, type, amount, currency_id, description, created_by, created_at, reference) VALUES (@cuentaOrigen, @cuentaDestino, 'DEBITO', @montoDecimal, 2, 'Pago de servicios', 2, NOW(), 'REF004');";
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
    }
}