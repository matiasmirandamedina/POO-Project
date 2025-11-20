using mini_home_banking.Controladores;
using mini_home_banking.Modelos;
using MySql.Data.MySqlClient;

namespace mini_home_banking.Vistas.UserControl
{
    public partial class UC_generateDebits : System.Windows.Forms.UserControl
    {
        private Conexion mConexion;

        public UC_generateDebits()
        {
            InitializeComponent();
        }
        public void SetConexion(Conexion conexion)
        {
            mConexion = conexion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string number_cardText = Number_card.Text;
            string debitsText = Debitos.Text;

            try
            {

                if (string.IsNullOrWhiteSpace(number_cardText) || string.IsNullOrWhiteSpace(debitsText))
                    throw new Own_Exception("Porfavor complete todos los campos");

                if (!long.TryParse(number_cardText, out _))
                    throw new Own_Exception("El numero de la tarjeta debe ser un numero");

                long number_card = Convert.ToInt64(number_cardText);


                decimal debits;
                if (!decimal.TryParse(debitsText, out debits))
                {
                    throw new Own_Exception("Por favor ingrese los debitos de manera valida (solo números).");
                }
                debits = Convert.ToDecimal(debitsText);

                bool verification = false;
                if (number_card == 0 || number_card < 0) verification = true;
                if (debits == 0 || debits < 0) verification = true;

                if (verification)
                {
                    throw new Own_Exception("Ninguno de los campos puede ser menor o igual a cero");
                }

                if (debits < 0 || debits == 0) throw new Own_Exception("El debito a generar no puede ser menor o igual cero");

                if (mConexion.getConexion() == null)
                    throw new Own_Exception("¡Error al conectar con la base de datos!");



                string queryId = "SELECT id, user_id FROM cards WHERE card_number_hash = @card_number_hash ";

                int card_id = 0;
                int user_id = 0;

                using (MySqlCommand cmd = new MySqlCommand(queryId, mConexion.getConexion()))
                {
                    cmd.Parameters.AddWithValue("@card_number_hash", number_card);
                    using (MySqlDataReader result_card = cmd.ExecuteReader())
                    {
                        if (result_card.Read())
                        {
                            card_id = result_card.GetInt32("id");
                            user_id = result_card.GetInt32("user_id");
                        }
                        else
                        {
                            MessageBox.Show("Tarjeta no encontrada");
                            return;
                        }
                    }
                }

                string query = "UPDATE cards SET available_limit = available_limit + @debits WHERE id = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, mConexion.getConexion()))
                {
                    cmd.Parameters.AddWithValue("@debits", debits);
                    cmd.Parameters.AddWithValue("@id", card_id);

                    int rowsInserted = cmd.ExecuteNonQuery();
                }

                string card_movements = @"
                INSERT INTO `card_movements`
                (`card_number`, `amount`, `type`, `description`, `created_by`, `created_at`)
                VALUES (@card_number, @amount, 'CARGA','Prestamo', 'Prestamo instantaneo', @user_id, NOW())";

                using (MySqlCommand cmd = new MySqlCommand(card_movements, mConexion.getConexion()))
                {
                    cmd.Parameters.AddWithValue("@card_number", card_id);
                    cmd.Parameters.AddWithValue("@amount", debits);
                    cmd.Parameters.AddWithValue("@user_id", user_id);


                    int rowsInserted = cmd.ExecuteNonQuery();
                }
                MessageBox.Show($"Se generaron los debitos con exito");
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

        private void Number_card_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Debitos.Focus();
            }
        }

        private void Debitos_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Generate_Debits.Focus();
            }
        }
    }
}