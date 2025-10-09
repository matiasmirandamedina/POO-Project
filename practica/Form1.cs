using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace practica
{
    public partial class Form1 : Form
    {
        private Conexion mConexion;
        public Form1()
        {
            InitializeComponent();
            mConexion = new Conexion();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string connectionString = "server = localhost; port = 3306; database = mini_home_banking; user = root; password = 1234;";

            //using (MySqlConnection conn = new MySqlConnection(connectionString))
            //{
            //    try
            //    {
            //        conn.Open();
            //        Console.WriteLine("Conexión exitosa a MySQL!");

            //        // Ejemplo: ejecutar una consulta
            //        string query = "SELECT * FROM users;";
            //        MySqlCommand cmd = new MySqlCommand(query, conn);
            //        MySqlDataReader reader = cmd.ExecuteReader();

            //        while (reader.Read())
            //        {
            //            Console.WriteLine(reader["nombre"]);
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("Error: " + ex.Message);
            //    }
            //}
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