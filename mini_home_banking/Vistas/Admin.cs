using mini_home_banking.Controladores;
using mini_home_banking.Modelos;
using MySql.Data.MySqlClient;

namespace mini_home_banking.Vistas
{
    public partial class Admin : Form
    {
        private Conexion mConexion;
        public Admin(User user)
        {
            InitializeComponent();
            mConexion = new Conexion();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string user_id = textBox4.Text;
            string account_type_id = textBox7.Text;
            string currency_id = textBox8.Text;
            string CBU = textBox9.Text;
            string current_balance = textBox12.Text;
            string alias = textBox13.Text;

            try
            {
                if (!int.TryParse(user_id, out _))
                    throw new Own_Exception("El ID de usuario debe ser un número válido.");

                if (!int.TryParse(account_type_id, out _))
                    throw new Own_Exception("El ID del tipo de cuenta debe ser un número válido.");

                if (!int.TryParse(currency_id, out _))
                    throw new Own_Exception("El ID de moneda debe ser un número válido.");

                if (!CBU.All(char.IsDigit))
                    throw new Own_Exception("El CBU debe tener solo numeros");

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

        private void button4_Click(object sender, EventArgs e)
        {
            string role = rol.Text;
            string username = textBox1.Text;
            string fullname = textBox2.Text;
            string email = textBox5.Text;
            string password = textBox6.Text;

            try
            {
                if (!int.TryParse(role, out _))
                    throw new Own_Exception("El rol debe ingresarse con el ID numérico (no el nombre).");

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

                string query = "INSERT INTO users (role_id, username, full_name, email, password_hash, created_at) " +
                               "VALUES (@role_id, @username, @full_name, @email, @password_hash, @created_at)";

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

        private void button1_Click(object sender, EventArgs e)
        {
            string number_card = Number_card.Text;
            string debitsText = Debitos.Text;

            try
            {

                if (string.IsNullOrWhiteSpace(number_card) || string.IsNullOrWhiteSpace(debitsText))
                    throw new Own_Exception("Porfavor complete todos los campos");

                if (!number_card.All(char.IsDigit))
                    throw new Own_Exception("El numero de tarjeta debe contener solo numeros");

                decimal debits;
                if (!decimal.TryParse(debitsText, out debits))
                {
                    throw new Own_Exception("Por favor ingrese los debitos de manera valida (solo números).");
                }
                debits = Convert.ToDecimal(debitsText);

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
                (`card_id`, `amount`, `type`, `description`, `created_by`, `created_at`)
                VALUES (@card_id, @amount, 'CARGA','Prestamo', 'Prestamo instantaneo', @user_id, NOW())";

                using (MySqlCommand cmd = new MySqlCommand(card_movements, mConexion.getConexion()))
                {
                    cmd.Parameters.AddWithValue("@card_id", card_id);
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

        private void Resumen_Click(object sender, EventArgs e)
        {
            string id_cardText = Id_card.Text;
            string MonthText = Month.Text;

            try
            {

                if (string.IsNullOrWhiteSpace(id_cardText) || string.IsNullOrWhiteSpace(MonthText))
                    throw new Own_Exception("Porfavor complete todos los campos");

                if (!id_cardText.All(char.IsDigit))
                    throw new Own_Exception("El id de la tarjeta debe ser un numero");

                if (!MonthText.All(char.IsDigit))
                    throw new Own_Exception("El mes debe estar puesto en forma numerica");

                int card_id = Convert.ToInt32(id_cardText);
                int month = Convert.ToInt32(MonthText);

                bool verification = false;
                if (card_id == 0 || card_id < 0) verification = true;
                if (month == 0 || month < 0) verification = true;

                if (verification)
                {
                    throw new Own_Exception("Ninguno de los campos puede ser menor o igual a cero");
                }

                if (month > 12) throw new Own_Exception("El mes no puede ser mayor a 12");

                if (mConexion.getConexion() == null)
                    throw new Own_Exception("¡Error al conectar con la base de datos!");



                string queryId = "SELECT * FROM cards WHERE id = @id ";


                using (MySqlCommand cmd = new MySqlCommand(queryId, mConexion.getConexion()))
                {
                    cmd.Parameters.AddWithValue("@id", card_id);
                    using (MySqlDataReader result_card = cmd.ExecuteReader())
                    {
                        if (result_card.Read())
                        {
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

        private void rol_KeyUp(object sender, KeyEventArgs e)
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

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                textBox7.Focus();
            }
        }

        private void textBox7_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                textBox8.Focus();
            }
        }

        private void textBox8_KeyUp(object sender, KeyEventArgs e)
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