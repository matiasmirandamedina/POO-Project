using mini_home_banking.Controladores;
using mini_home_banking.Modelos;
using MySql.Data.MySqlClient;

namespace mini_home_banking.Vistas.UserControl
{
    public partial class UC_summaryCard : System.Windows.Forms.UserControl
    {
        private Conexion mConexion;

        public UC_summaryCard()
        {
            InitializeComponent();
        }

        public void SetConexion(Conexion conexion)
        {
            mConexion = conexion;
        }

        private void Resumen_Click(object sender, EventArgs e)
        {
            string number_cardText = Card_number.Text;
            string MonthText = Month.Text;

            try
            {

                if (string.IsNullOrWhiteSpace(number_cardText) || string.IsNullOrWhiteSpace(MonthText))
                    throw new Own_Exception("Porfavor complete todos los campos");


                if (!long.TryParse(number_cardText, out _))
                    throw new Own_Exception("El numero de la tarjeta debe ser un numero");

                if (!int.TryParse(MonthText, out _))
                    throw new Own_Exception("El mes debe estar puesto en forma numerica");

                long card_number = Convert.ToInt64(number_cardText);
                int month = Convert.ToInt32(MonthText);

                bool verification = false;
                if (card_number == 0 || card_number < 0) verification = true;
                if (month == 0 || month < 0) verification = true;

                if (verification)
                {
                    throw new Own_Exception("Ninguno de los campos puede ser menor o igual a cero");
                }

                if (month > 12) throw new Own_Exception("El mes no puede ser mayor a 12");

                if (mConexion.getConexion() == null)
                    throw new Own_Exception("¡Error al conectar con la base de datos!");



                string queryId = "SELECT * FROM cards WHERE card_number_hash = @card_number ";
                int card_id = 0;

                using (MySqlCommand cmd = new MySqlCommand(queryId, mConexion.getConexion()))
                {
                    cmd.Parameters.AddWithValue("@card_number", card_number);
                    using (MySqlDataReader result_card = cmd.ExecuteReader())
                    {
                        if (result_card.Read())
                        {
                            card_id = Convert.ToInt32(result_card["id"]);
                            MessageBox.Show("Tarjeta encontrada");
                        }
                        else
                        {
                            MessageBox.Show("Tarjeta no encontrada");
                            return;
                        }
                    }
                }

                string query = "SELECT * from card_movements where MONTH(created_at) = @month AND card_id = @card_id LIMIT 1";

                using (MySqlCommand cmd = new MySqlCommand(query, mConexion.getConexion()))
                {
                    cmd.Parameters.AddWithValue("@month", month);
                    cmd.Parameters.AddWithValue("@card_id", card_id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            CardMovement cm1 = new CardMovement(
                            Convert.ToInt32(reader["id"]),
                            Convert.ToInt32(reader["card_id"]),
                            Convert.ToDecimal(reader["amount"]),
                            reader["type"]!.ToString(),
                            reader["description"].ToString(),
                            Convert.ToInt32(reader["created_by"]),
                            Convert.ToDateTime(reader["created_at"])
                            );
                            MessageBox.Show(cm1.ToString());
                        }
                        else
                        {
                            throw new Own_Exception("Movimiento de tarjeta no encontrada");
                        }
                    }
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

        private void Id_card_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Month.Focus();
            }
        }

        private void Month_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Resumen.Focus();
            }
        }
    }
}