namespace mini_home_banking.Controladores
{
    public class Account
    {
        private int Id { get; set; }
        private string Alias { get; set; }
        private string Tipo { get; set; }
        private decimal Saldo { get; set; }
        private string Cbu { get; set; }

        public Account(int Id,string Alias, string Tipo, decimal Saldo, string cbu)
        {
            this.Id = Id;
            this.Alias = Alias;
            this.Tipo = Tipo;
            this.Saldo = Saldo;
            Cbu = cbu;
        }

        public override string ToString()
        {
            // Esto define lo que se muestra en la ListBox
            return $"{Alias} - {Tipo} - ${Saldo} - {Cbu}";
        }

        public string Get_Alias()
        {
            return Alias;
        }

        public string Get_Cbu()
        {
            return Cbu;
        }

        public decimal Get_Saldo()
        {
            return Saldo;
        }
        public decimal Set_Saldo(decimal Saldo)
        {
            this.Saldo = Saldo;
            return Saldo;
        }
    }
}