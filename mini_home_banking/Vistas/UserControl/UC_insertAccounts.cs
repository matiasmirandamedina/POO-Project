using mini_home_banking.Controladores;
using mini_home_banking.Modelos;
using MySql.Data.MySqlClient;

namespace mini_home_banking.Vistas.UserControl
{
    public partial class UC_insertAccounts : System.Windows.Forms.UserControl
    {
        private Conexion mConexion;

        public UC_insertAccounts()
        {
            InitializeComponent();
        }
        public void SetConexion(Conexion conexion)
        {
            mConexion = conexion;
        }

        public List<(int id, string username)> Obtener_Usuarios()
        {
            List<(int id, string username)> users = new List<(int, string)>();

            string obtainUsersQuery = "SELECT id, username FROM users;";

            if (mConexion.getConexion() != null)
            {
                using (MySqlCommand cmd = new MySqlCommand(obtainUsersQuery, mConexion.getConexion()))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            users.Add((Convert.ToInt32(reader["id"]), reader["username"].ToString()));
                        }
                    }
                }
            }

            return users;
        }

        public List<(int id, string description)> Obtener_TiposCuentas()
        {
            List<(int id, string description)> accountTypes = new List<(int, string)>();

            string obtainAccountTypesQuery = "SELECT id, description FROM account_types;";

            if (mConexion.getConexion() != null)
            {
                using (MySqlCommand cmd = new MySqlCommand(obtainAccountTypesQuery, mConexion.getConexion()))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            accountTypes.Add((Convert.ToInt32(reader["id"]), reader["description"].ToString()));
                        }
                    }
                }
            }

            return accountTypes;
        }

        public List<(int id, string name)> Obtener_Monedas()
        {
            List<(int id, string name)> currencies = new List<(int, string)>();

            string obtainCurrenciesQuery = "SELECT id, name FROM currencies;";

            if (mConexion.getConexion() != null)
            {
                using (MySqlCommand cmd = new MySqlCommand(obtainCurrenciesQuery, mConexion.getConexion()))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            currencies.Add((Convert.ToInt32(reader["id"]), reader["name"].ToString()));
                        }
                    }
                }
            }

            return currencies;
        }

        private void UC_insertAccounts_Load(object sender, EventArgs e)
        {
            var users = Obtener_Usuarios()
                .OrderBy(u => u.id)
                .Select(u => new { u.id, mostrarInfo = $"{u.id} - {u.username}" })
                .ToList();

            comboBox2.DataSource = users;
            comboBox2.DisplayMember = "mostrarInfo";
            comboBox2.ValueMember = "id";

            var accountTypes = Obtener_TiposCuentas()
                .OrderBy(aT => aT.id)
                .Select(aT => new { aT.id, mostrarInfo = $"{aT.id} - {aT.description}" })
                .ToList();

            comboBox3.DataSource = accountTypes;
            comboBox3.DisplayMember = "mostrarInfo";
            comboBox3.ValueMember = "id";

            var currencies = Obtener_Monedas()
                .OrderBy(c => c.id)
                .Select(c => new { c.id, mostrarInfo = $"{c.id} - {c.name}" })
                .ToList();

            comboBox4.DataSource = currencies;
            comboBox4.DisplayMember = "mostrarInfo";
            comboBox4.ValueMember = "id";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int user_id = (int)comboBox2.SelectedValue;
            int account_type_id = (int)comboBox3.SelectedValue;
            int currency_id = (int)comboBox4.SelectedValue;
            string CBU = textBox9.Text;
            string current_balance = textBox12.Text;
            string alias = textBox13.Text;

            try
            {
                if (!CBU.All(char.IsDigit))
                    throw new Own_Exception("El valor no es vaido en el CBU");

                if (!decimal.TryParse(current_balance, out decimal saldo))
                    throw new Own_Exception("El saldo debe ser un número válido.");

                if (saldo < 0)
                    throw new Own_Exception("El saldo no puede ser menor a 0.");

                if (mConexion.getConexion() == null)
                    throw new Own_Exception("¡Error al conectar con la base de datos!");

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
            catch (Own_Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar cuenta: " + ex.Message);
            }
        }

        private void comboBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                comboBox3.Focus();
            }
        }

        private void comboBox3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                comboBox4.Focus();
            }
        }

        private void comboBox4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                textBox9.Focus();
            }
        }

        private void textBox9_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                textBox12.Focus();
            }
        }

        private void textBox12_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                textBox13.Focus();
            }
        }

        private void textBox13_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Insert_Account.Focus();
            }
        }
    }
}