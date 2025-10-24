using Google.Protobuf.WellKnownTypes;
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
    public partial class Admin : Form
    {
        private Conexion mConexion;
        public Admin(Usuario user)
        {
            InitializeComponent();
            mConexion = new Conexion();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string user_id = textBox4.Text.Trim();
            string account_type_id = textBox7.Text.Trim();
            string currency_id = textBox8.Text.Trim();
            string CBU = textBox9.Text.Trim();
            string current_balance = textBox12.Text.Trim();
            string alias = textBox13.Text.Trim();

            try
            {
                if (!int.TryParse(user_id, out _))
                    throw new Exception("El ID de usuario debe ser un número válido.");

                if (!int.TryParse(account_type_id, out _))
                    throw new Exception("El ID del tipo de cuenta debe ser un número válido.");

                if (!int.TryParse(currency_id, out _))
                    throw new Exception("El ID de moneda debe ser un número válido.");

                if (!CBU.All(char.IsDigit) || CBU.Length != 22)
                    throw new Exception("El CBU debe tener exactamente 22 dígitos numéricos.");

                if (!decimal.TryParse(current_balance, out decimal saldo))
                    throw new Exception("El saldo debe ser un número válido.");

                if (saldo < 0)
                    throw new Exception("El saldo no puede ser menor a 0.");

                if (mConexion.getConexion() == null)
                    throw new Exception("¡Error al conectar con la base de datos!");

                string query = "INSERT INTO accounts (user_id, account_type_id, currency_id, cbu, current_balance, alias) " +
                               "VALUES (@user_id, @account_type_id, @currency_id, @cbu, @current_balance, @alias)";

                using (MySqlCommand cmd = new MySqlCommand(query, mConexion.getConexion()))
                {
                    cmd.Parameters.AddWithValue("@user_id", user_id);
                    cmd.Parameters.AddWithValue("@account_type_id", account_type_id);
                    cmd.Parameters.AddWithValue("@currency_id", currency_id);
                    cmd.Parameters.AddWithValue("@cbu", CBU);
                    cmd.Parameters.AddWithValue("@current_balance", saldo);
                    cmd.Parameters.AddWithValue("@alias", alias);

                    int rowsInserted = cmd.ExecuteNonQuery();

                    if (rowsInserted > 0)
                        MessageBox.Show("Cuenta insertada con éxito.");
                    else
                        MessageBox.Show("No se pudo insertar la cuenta.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar cuenta: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string role = rol.Text.Trim();
            string username = textBox1.Text.Trim();
            string fullname = textBox2.Text.Trim();
            string email = textBox5.Text.Trim();
            string password = textBox6.Text.Trim();

            try
            {
                if (!int.TryParse(role, out _))
                    throw new Exception("El rol debe ingresarse con el ID numérico (no el nombre).");

                if (string.IsNullOrWhiteSpace(username))
                    throw new Exception("El nombre de usuario no puede estar vacío.");

                if (string.IsNullOrWhiteSpace(fullname))
                    throw new Exception("El nombre completo no puede estar vacío.");

                if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
                    throw new Exception("Debe ingresar un email válido.");

                if (string.IsNullOrWhiteSpace(password))
                    throw new Exception("Debe ingresar una contraseña.");

                if (mConexion.getConexion() == null)
                    throw new Exception("¡Error al conectar con la base de datos!");

                string query = "INSERT INTO users (role_id, username, full_name, email, password_hash, created_at) " +
                               "VALUES (@role_id, @username, @full_name, @email, @password_hash, @created_at)";

                using (MySqlCommand cmd = new MySqlCommand(query, mConexion.getConexion()))
                {
                    cmd.Parameters.AddWithValue("@role_id", role);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@full_name", fullname);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password_hash", password);
                    cmd.Parameters.AddWithValue("@created_at", DateTime.Now);

                    int rowsInserted = cmd.ExecuteNonQuery();

                    if (rowsInserted > 0)
                        MessageBox.Show("Usuario insertado con éxito.");
                    else
                        MessageBox.Show("No se pudo insertar el usuario.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar usuario: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
        private void label13_Click(object sender, EventArgs e)
        {

        }

     }
}