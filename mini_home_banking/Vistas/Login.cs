using mini_home_banking.Modelos;
using mini_home_banking.Controladores;
using MySql.Data.MySqlClient;
using mini_home_banking.Vistas.UserControl;

namespace mini_home_banking.Vistas
{
    public partial class Login : Form
    {
        private Conexion mConexion;
        public Login()
        {
            InitializeComponent();
            mConexion = new Conexion();
        }

        private void login_Click(object sender, EventArgs e)
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
                            Client f1 = new Client(user);
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

        private void email_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                pass.Focus();
            }
        }

        private void pass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                login.Focus();
            }
        } 

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pass.PasswordChar == '*')
            {
                pass.PasswordChar = '\0'; 
            }
            else
            {
                pass.PasswordChar = '*';
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}