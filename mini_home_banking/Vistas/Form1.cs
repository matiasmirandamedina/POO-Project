using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using mini_home_banking.Modelos;
using MySql.Data.MySqlClient;

namespace mini_home_banking.Vistas
{
    public partial class Form1 : Form
    {
        private Conexion mConexion;
        public Form1()
        {
            InitializeComponent();
            mConexion = new Conexion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "";
            MySqlDataReader reader = null;
            string query = "SELECT * FROM users;";

            if (mConexion.getConexion() != null)
            {
                MySqlCommand cmd = new MySqlCommand(query, mConexion.getConexion());
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    result += $"ID: {reader["id"]}, Usuario: {reader["username"]}";
                }

                MessageBox.Show(result);
                reader.Close();
            }
            else
            {
                MessageBox.Show("¡Error al conectar!");
            }
        }
    }
}