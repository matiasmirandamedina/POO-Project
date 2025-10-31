﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using mini_home_banking.Modelos;
using mini_home_banking.Controladores;
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

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Login_Click(object sender, EventArgs e)
        {
            try
            {
                string email = this.email.Text;
                string password = pass.Text;
                bool at = false;

                if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                {
                    throw new Own_Exception("Ingrese los valores correspondientes");
                }

                for (int i = 0; i < email.Length; i++)
                {
                    if (email[i] == '@')
                    {
                        at = true;
                    }
                }

                if (at == false) throw new Own_Exception("Falta el @ en gmail");


                MySqlDataReader cons = null;

                string login = "SELECT * FROM users WHERE email = @email AND password_hash = MD5(@password_hash);";

                if (mConexion.getConexion() != null)
                {
                    MySqlCommand log = new MySqlCommand(login, mConexion.getConexion());
                    log.Parameters.AddWithValue("@email", email);
                    log.Parameters.AddWithValue("@password_hash", password);

                    cons = log.ExecuteReader();

                    if (cons.Read())
                    {
                        MessageBox.Show("Login exitoso");

                        User user = new User(Convert.ToInt32(cons["id"]),
                        Convert.ToInt32(cons["role_id"]),
                        cons["username"].ToString(),
                        cons["full_name"].ToString(),
                        cons["email"].ToString(),
                        cons["password_hash"].ToString());

                        if (Convert.ToInt32(cons["role_id"]) == 1)
                        {
                            Admin f1 = new Admin(user);
                            f1.Show();
                        }
                        else
                        {
                            Home f1 = new Home(user);
                            f1.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Login fallido: Datos incorrectos");
                    }

                    cons.Close();
                }
                else
                {
                    MessageBox.Show("¡Error al conectar!");
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

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void email_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Login.Focus();
            }
        }

        private void pass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Login.Focus();
            }
        }
    }
}