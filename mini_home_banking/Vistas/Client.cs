using mini_home_banking.Controladores;
using mini_home_banking.Modelos;
using mini_home_banking.Vistas.UserControl;
using MySql.Data.MySqlClient;
using System.Text.Json;

namespace mini_home_banking.Vistas
{
    public partial class Client : Form
    {
        private User user;
        private Conexion mConexion;

        public Client(User user)
        {
            InitializeComponent();
            this.user = user;
            mConexion = new Conexion();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            this.Text = $"Client - {user.GetUsername()}";
        }

        private void CargarUserControl(System.Windows.Forms.UserControl uc)
        {
            panel1.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc);
        }

        private void homeUserVar_Click(object sender, EventArgs e)
        {
            UC_home uc = new UC_home(Obtener_Cuentas(), user);
            uc.SetConexion(mConexion);
            CargarUserControl(uc);
        }

        private void transferenceVar_Click(object sender, EventArgs e)
        {
            UC_transfer uc = new UC_transfer(Obtener_Cuentas(), user, ObtenerDolarOficial(), ObtenerEuroOficial());
            uc.SetConexion(mConexion);
            CargarUserControl(uc);
        }

        private async void convertCurrencyVar_Click(object sender, EventArgs e)
        {
            try
            {
                var dolar = await ObtenerDolarOficial();
                var euro = await ObtenerEuroOficial();

                UC_converter uc = new UC_converter(dolar, euro);
                uc.SetConexion(mConexion);
                CargarUserControl(uc);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener cotizaciones: " + ex.Message);
            }
        }

        public List<Account> Obtener_Cuentas()
        {
            MySqlDataReader reader = null;
            List<Account> accounts = new List<Account>();

            string query = "SELECT a.id, at.description, a.currency_id, a.alias, a.current_balance, a.cbu FROM accounts a JOIN account_types at ON a.account_type_id = at.id WHERE user_id = @user_id";

            if (mConexion.getConexion() != null)
            {
                MySqlCommand cmd = new MySqlCommand(query, mConexion.getConexion());
                cmd.Parameters.AddWithValue("@user_id", user.Getid());

                reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    Account account = new Account(Convert.ToInt32(reader["id"]), reader["alias"].ToString(), reader["description"].ToString(), Convert.ToDecimal(reader["current_balance"]), reader["cbu"].ToString(), Convert.ToInt32(reader["currency_id"]));
                    accounts.Add(account);
                }
                reader.Close();

            }
            return accounts;
        }
        private async Task<currency> ObtenerDolarOficial()
        {
            string url = "https://dolarapi.com/v1/dolares/oficial";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string json = await response.Content.ReadAsStringAsync();

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                return JsonSerializer.Deserialize<currency>(json, options);
            }
        }

        private async Task<currency> ObtenerEuroOficial()
        {
            string url = "https://dolarapi.com/v1/cotizaciones/eur";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string json = await response.Content.ReadAsStringAsync();

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                return JsonSerializer.Deserialize<currency>(json, options);
            }
        }
    }
}