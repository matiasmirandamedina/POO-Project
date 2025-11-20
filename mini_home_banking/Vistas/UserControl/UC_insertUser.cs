using mini_home_banking.Controladores;
using mini_home_banking.Modelos;
using MySql.Data.MySqlClient;

namespace mini_home_banking.Vistas.UserControl
{
    public partial class UC_insertUser : System.Windows.Forms.UserControl
    {
        private Conexion mConexion;
        public UC_insertUser()
        {
            InitializeComponent();
        }
        public void SetConexion(Conexion conexion)
        {
            mConexion = conexion;
        }

        public List<Role> Obtener_Roles()
        {
            List<Role> roles = new List<Role>();

            string obtainRolesQuery = "SELECT id, name FROM roles;";

            if (mConexion.getConexion() != null)
            {
                using (MySqlCommand cmd = new MySqlCommand(obtainRolesQuery, mConexion.getConexion()))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Role role = new Role(Convert.ToInt32(reader["id"]), reader["name"].ToString());
                            roles.Add(role);
                        }
                    }
                }
            }
            return roles;
        }

        private void UC_insertUser_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Obtener_Roles();
            comboBox1.DisplayMember = "mostrarInfo";
            comboBox1.ValueMember = "id";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int role = (int)comboBox1.SelectedValue;
            string username = textBox1.Text;
            string fullname = textBox2.Text;
            string email = textBox5.Text;
            string password = textBox6.Text;

            try
            {
                if (string.IsNullOrWhiteSpace(username))
                    throw new Own_Exception("El nombre de usuario no puede estar vacío.");

                if (string.IsNullOrWhiteSpace(fullname))
                    throw new Own_Exception("El nombre completo no puede estar vacío.");

                if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
                    throw new Own_Exception("Debe ingresar un email válido.");

                if (string.IsNullOrWhiteSpace(password))
                    throw new Own_Exception("Debe ingresar una contraseña.");

                if (mConexion.getConexion() == null)
                    throw new Own_Exception("¡Error al conectar con la base de datos!");

                string checkQuery = "SELECT COUNT(*) FROM users WHERE username = @username OR email = @email";
                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, mConexion.getConexion()))
                {
                    checkCmd.Parameters.AddWithValue("@username", username);
                    checkCmd.Parameters.AddWithValue("@email", email);
                    int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (exists > 0)
                        throw new Own_Exception("El nombre de usuario o el correo ya están registrados.");
                }

                string query = "INSERT INTO users (role_id, username, full_name, email, password_hash, created_at) " +
                               "VALUES (@role_id, @username, @full_name, @email, MD5(@password_hash), @created_at)";

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
            catch (Own_Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar usuario: " + ex.Message);
            }
        }

        private void comboBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                textBox1.Focus();
            }

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                textBox5.Focus();
            }
        }

        private void textBox5_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                textBox6.Focus();
            }
        }

        private void textBox6_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Insert_User.Focus();
            }
        }
    }
}