using mini_home_banking.Controladores;
using mini_home_banking.Modelos;
using MySql.Data.MySqlClient;

namespace mini_home_banking.Vistas.UserControl
{
    public partial class UC_home : System.Windows.Forms.UserControl
    {
        private User user;
        private List<Account> accounts;
        private Conexion mConexion;

        public UC_home(List<Account> accounts, User user)
        {
            InitializeComponent();
            this.accounts = accounts;
            this.user = user;
            mConexion = new Conexion();
        }
        public void SetConexion(Conexion conexion)
        {
            mConexion = conexion;
        }

        private void UC_home_Load(object sender, EventArgs e)
        {
            try
            {
                listBoxCuentas.DataSource = accounts;
                listBoxCuentas.DisplayMember = "mostrarInfo";

                string name = user.GetUsername();
                this.Text = $"Home: {name}";


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
    }
}