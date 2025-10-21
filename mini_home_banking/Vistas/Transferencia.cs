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
        private List<Cuenta> cuentas;

        public Transferencia(List<Cuenta> cuentas)
        {
            InitializeComponent();
            this.cuentas = cuentas;
            mConexion = new Conexion();
        }

        private void Transferencia_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = cuentas;
        }

        private void transferir_Click(object sender, EventArgs e)
        {
            try
            {
                string cuentaOrigen = this.cuentaOrigen.Text;
                string cuentaDestino = this.cuentaDestino.Text;
                string montoText = this.monto.Text;

                if (string.IsNullOrWhiteSpace(montoText) || string.IsNullOrWhiteSpace(cuentaDestino) || string.IsNullOrWhiteSpace(cuentaOrigen))
                {
                    throw new Own_Exception("Por favor complete todos los campos");
                }

                decimal monto;
                if (!decimal.TryParse(montoText, out monto))
                {
                    throw new Own_Exception("Por favor ingrese un monto válido (solo números).");
                }
                monto = Convert.ToDecimal(montoText);

                foreach (Cuenta account in cuentas)
                {
                    if (account.Get_Cbu() == cuentaOrigen || account.Get_Alias() == cuentaOrigen)
                    {
                        Cuenta accountVer = account;
                        if (accountVer.Get_Saldo() < monto) throw new Own_Exception($"El monto seleccionado supera el actual. Ingrese un monto igual o menor a {accountVer.Get_Saldo()}");
                    }
                }

                if(monto < 0 || monto == 0) throw new Own_Exception($"El monto seleccionado no puede ser igual o menor a cero");

                string transferir = "INSERT INTO transactions (account_id, destination_account_id, type, amount, currency_id, description, created_by, created_at, reference) VALUES (@cuentaOrigen, @cuentaDestino, 'DEBITO', @montoDecimal, 2, 'Pago de servicios', 2, NOW(), 'REF004');";
                string descontar = "UPDATE accounts SET current_balance = current_balance - @montoDecimal WHERE id = @cuentaOrigen;";
                string sumar = "UPDATE accounts SET current_balance = current_balance + @montoDecimal WHERE id = @cuentaDestino;";

                int idOrigen = 0;
                int idDestino = 0;

                string queryId = "SELECT id FROM accounts WHERE cbu = @cbu OR alias = @alias";


                using (MySqlCommand cmd = new MySqlCommand(queryId, mConexion.getConexion()))
                {
                    cmd.Parameters.AddWithValue("@cbu", cuentaOrigen);
                    cmd.Parameters.AddWithValue("@alias", cuentaOrigen);
                    using (MySqlDataReader resultOrigen = cmd.ExecuteReader())
                    {
                        if (resultOrigen.Read())
                            idOrigen = resultOrigen.GetInt32("id");
                        else
                        {
                            MessageBox.Show("Cuenta de origen no encontrada");
                            return;
                        }
                    }
                }

                using (MySqlCommand cmd = new MySqlCommand(queryId, mConexion.getConexion()))
                {
                    cmd.Parameters.AddWithValue("@cbu", cuentaDestino);
                    cmd.Parameters.AddWithValue("@alias", cuentaDestino);
                    using (MySqlDataReader resultDestino = cmd.ExecuteReader())
                    {
                        if (resultDestino.Read())
                            idDestino = resultDestino.GetInt32("id");
                        else
                        {
                            MessageBox.Show("Cuenta de destino no encontrada");
                            return;
                        }
                    }
                }

                if (mConexion.getConexion() != null)
                {
                    using (MySqlCommand log = new MySqlCommand(transferir, mConexion.getConexion()))
                    {
                        log.Parameters.AddWithValue("@cuentaOrigen", idOrigen);
                        log.Parameters.AddWithValue("@cuentaDestino", idDestino);
                        log.Parameters.AddWithValue("@montoDecimal", monto);
                        log.ExecuteNonQuery();
                    }

                    using (MySqlCommand cmdDescontar = new MySqlCommand(descontar, mConexion.getConexion()))
                    {
                        cmdDescontar.Parameters.AddWithValue("@montoDecimal", monto);
                        cmdDescontar.Parameters.AddWithValue("@cuentaOrigen", idOrigen);
                        cmdDescontar.ExecuteNonQuery();
                    }

                    using (MySqlCommand cmdSumar = new MySqlCommand(sumar, mConexion.getConexion()))
                    {
                        cmdSumar.Parameters.AddWithValue("@montoDecimal", monto);
                        cmdSumar.Parameters.AddWithValue("@cuentaDestino", idDestino);
                        cmdSumar.ExecuteNonQuery();
                    }

                    MessageBox.Show($"Se ha transferido ${monto} de la cuenta {cuentaOrigen} a la cuenta {cuentaDestino}");
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