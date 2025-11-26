using mini_home_banking.Controladores;
using mini_home_banking.Modelos;

namespace mini_home_banking.Vistas.UserControl
{
    public partial class UC_converter : System.Windows.Forms.UserControl
    {
        private currency dolar;
        private currency euro;
        private Conexion mConexion;

        public UC_converter(currency dolar, currency euro)
        {
            InitializeComponent();
            this.dolar = dolar;
            this.euro = euro;
            mConexion = new Conexion();
        }
        public void SetConexion(Conexion conexion)
        {
            mConexion = conexion;
        }

        private void UC_converter_Load(object sender, EventArgs e)
        {
            currencieA.DataSource = new List<string> { "Peso", "Dolar", "Euro" };

            currencieC.DataSource = new List<string> { "Dolar", "Euro" };

            currencieA.SelectedIndexChanged += CurrencieA_SelectedIndexChanged;
        }

        private void CurrencieA_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = currencieA.Text;

            switch (seleccion)
            {
                case "Peso":
                    currencieC.DataSource = new List<string> { "Dolar", "Euro" };
                    break;

                case "Dolar":
                    currencieC.DataSource = new List<string> { "Peso", "Euro" };
                    break;

                case "Euro":
                    currencieC.DataSource = new List<string> { "Peso", "Dolar" };
                    break;
            }
        }

        private void Convertion_Click(object sender, EventArgs e)
        {
            try
            {
                string amountText = this.amount.Text;
                string currencyA = currencieA.Text;
                string currencyC = currencieC.Text;


                if (string.IsNullOrWhiteSpace(amountText))
                {
                    throw new Own_Exception("Por favor complete todos los campos");
                }

                decimal amount;
                if (!decimal.TryParse(amountText, out amount))
                {
                    throw new Own_Exception("Por favor ingrese un monto válido (solo números).");
                }
                amount = Convert.ToDecimal(amountText);

                if (amount <= 0) throw new Own_Exception("El monto elegido no tiene que ser menor o igual a cero");

                decimal res = 0;
                if (currencyA == "Peso")
                {
                    if (currencyC == "Dolar")
                    {
                        res = amount / dolar.venta;
                    }
                    if (currencyC == "Euro")
                    {
                        res = amount / euro.venta;
                    }
                }
                if (currencyA == "Dolar")
                {
                    if (currencyC == "Peso")
                    {
                        res = amount * dolar.compra;
                    }
                    if (currencyC == "Euro")
                    {
                        res = amount * (dolar.compra / euro.venta);
                    }
                }
                if (currencyA == "Euro")
                {
                    if (currencyC == "Peso")
                    {
                        res = amount * euro.compra;
                    }
                    if (currencyC == "Dolar")
                    {
                        res = amount * (euro.compra / dolar.venta);
                    }
                }

                MessageBox.Show($"La conversion de {currencyA} a {currencyC} con la cantidad de {amount} es de: ${res:N2}");
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
    }
}