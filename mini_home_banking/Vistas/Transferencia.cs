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
            string cuentaOrigen = this.cuentaOrigen.Text;
            string cuentaDestino = this.cuentaDestino.Text;
            string monto = this.monto.Text;

            if (string.IsNullOrWhiteSpace(monto) || string.IsNullOrWhiteSpace(cuentaDestino) || string.IsNullOrWhiteSpace(cuentaOrigen))
            {
                MessageBox.Show("Por favor complete todos los campos");
                return;
            }

            decimal montoDecimal;
            if (!decimal.TryParse(monto, out montoDecimal))
            {
                MessageBox.Show("Monto inválido");
                return;
            }

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
                    log.Parameters.AddWithValue("@montoDecimal", montoDecimal);
                    log.ExecuteNonQuery();
                }

                using (MySqlCommand cmdDescontar = new MySqlCommand(descontar, mConexion.getConexion()))
                {
                    cmdDescontar.Parameters.AddWithValue("@montoDecimal", montoDecimal);
                    cmdDescontar.Parameters.AddWithValue("@cuentaOrigen", idOrigen);
                    cmdDescontar.ExecuteNonQuery();
                }

                using (MySqlCommand cmdSumar = new MySqlCommand(sumar, mConexion.getConexion()))
                {
                    cmdSumar.Parameters.AddWithValue("@montoDecimal", montoDecimal);
                    cmdSumar.Parameters.AddWithValue("@cuentaDestino", idDestino);
                    cmdSumar.ExecuteNonQuery();
                }

                MessageBox.Show($"Se ha transferido ${monto} de la cuenta {cuentaOrigen} a la cuenta {cuentaDestino}");
            }
        }
    }
}