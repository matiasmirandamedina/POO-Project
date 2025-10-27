﻿using System;
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
        private User user;
        private Conexion mConexion;
        public Home(User user)
        {
            InitializeComponent();
            this.user = user;
            mConexion = new Conexion();
        }

        public List<Account> Obtener_Cuentas()
        {

            MySqlDataReader reader = null;
            List<Account> accounts = new List<Account>();

            string query = "SELECT a.id,at.description, a.alias, a.current_balance, a.cbu FROM accounts a JOIN account_types at ON" +
                " a.account_type_id = at.id WHERE user_id = @user_id";

            if (mConexion.getConexion() != null)
            {
                MySqlCommand cmd = new MySqlCommand(query, mConexion.getConexion());
                cmd.Parameters.AddWithValue("@user_id", user.Getid());

                reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    Account account = new Account(Convert.ToInt32(reader["id"]),reader["alias"].ToString(), reader["description"].ToString(), Convert.ToDecimal(reader["current_balance"]),reader["cbu"].ToString());
                    accounts.Add(account);

                }
                reader.Close();

            }
            return accounts;
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
                    List<Card> cards = new List<Card>();

                    MySqlCommand cmd = new MySqlCommand(query, mConexion.getConexion());
                    cmd.Parameters.AddWithValue("@user_id", user.Getid());
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Card tarjeta = new Card(reader["card_type"].ToString(), Convert.ToDecimal(reader["available_limit"]), Convert.ToDateTime(reader["expiration"]));
                        cards.Add(tarjeta);

                    }
                    listBoxTarjetas.DataSource = cards;

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
