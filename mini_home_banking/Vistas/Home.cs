using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;
using mini_home_banking.Controladores;
using mini_home_banking.Modelos;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace mini_home_banking.Vistas
{
    public partial class Home : Form
    {
        private Usuario user;
        private Conexion mConexion;
        public Home(Usuario user)
        {
            InitializeComponent();
            this.user = user;
            mConexion = new Conexion();
        }

        public List<Cuenta> Obtener_Cuentas()
        {

            MySqlDataReader reader = null;
            List<Cuenta> cuentas = new List<Cuenta>();

            string query = "SELECT a.id,at.description, a.alias, a.current_balance, a.cbu FROM accounts a JOIN account_types at ON" +
                " a.account_type_id = at.id WHERE user_id = @user_id";

            if (mConexion.getConexion() != null)
            {
                MySqlCommand cmd = new MySqlCommand(query, mConexion.getConexion());
                cmd.Parameters.AddWithValue("@user_id", user.Getid());

                reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    Cuenta cuenta = new Cuenta(Convert.ToInt32(reader["id"]),reader["alias"].ToString(), reader["description"].ToString(), Convert.ToDecimal(reader["current_balance"]),reader["cbu"].ToString());
                    cuentas.Add(cuenta);

                }
                reader.Close();

            }
            return cuentas;
        }
        private void Home_Load(object sender, EventArgs e)
        {
            try
            {
                listBoxCuentas.DataSource = Obtener_Cuentas();

                MySqlDataReader reader = null;
                string query = "SELECT card_type, expiration, available_limit FROM cards WHERE user_id = @user_id";

                if (mConexion.getConexion() != null)
                {
                    List<Tarjeta> tarjetas = new List<Tarjeta>();

                    MySqlCommand cmd2 = new MySqlCommand(query, mConexion.getConexion());
                    cmd2.Parameters.AddWithValue("@user_id", user.Getid());
                    reader = cmd2.ExecuteReader();
                    while (reader.Read())
                    {
                        Tarjeta tarjeta = new Tarjeta(reader["card_type"].ToString(), Convert.ToDecimal(reader["available_limit"]), Convert.ToDateTime(reader["expiration"]));
                        tarjetas.Add(tarjeta);

                    }
                    listBoxTarjetas.DataSource = tarjetas;

                    reader.Close();
                }
                else
                {
                    MessageBox.Show("¡Error al conectar!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void listBoxCuentas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxTarjetas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Transferencia transferencia = new Transferencia(Obtener_Cuentas());
            transferencia.Show();
        }
    }
}
