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


        private void Home_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlDataReader reader = null;

                string query = "SELECT at.description, a.alias, a.current_balance FROM accounts a JOIN account_types at ON" +
                    " a.account_type_id = at.id WHERE user_id = @user_id";

                if (mConexion.getConexion() != null)
                {
                    MySqlCommand cmd = new MySqlCommand(query, mConexion.getConexion());
                    cmd.Parameters.AddWithValue("@user_id", user.Getid());

                    reader = cmd.ExecuteReader();
                    List<Cuenta> cuentas = new List<Cuenta>();

                        while (reader.Read()) {
                            Cuenta cuenta = new Cuenta(reader["alias"].ToString(), reader["description"].ToString(), Convert.ToDecimal(reader["current_balance"]));
                            cuentas.Add(cuenta);
                            
                        }
                        listBoxCuentas.DataSource = cuentas;
                    
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
    }
}
