namespace mini_home_banking.Controladores
{
    internal class Card
    {
        public string Tipo { get; set; }
        public decimal Dinero_disponible { get; set; }
        public DateTime Expiration { get; set; }

        public Card(string Tipo, decimal Dinero_disponible, DateTime Expiration)
        {
            this.Tipo = Tipo;
            this.Dinero_disponible = Dinero_disponible;
            this.Expiration = Expiration;
        }

        public override string ToString()
        {
            return $"{Tipo} - Dinero disponible: {Dinero_disponible} - Vence: {Expiration.ToShortDateString()}";
        }

    }
}