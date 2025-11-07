namespace mini_home_banking.Controladores
{
    public class Account
    {
        public int Id { get; set; }
        public string Alias { get; set; }
        public string Tipo { get; set; }
        public decimal Saldo { get; set; }
        public string Cbu { get; set; }
        public int monedaId { get; set; }

        public Account(int Id, string Alias, string Tipo, decimal Saldo, string cbu, int monedaId)
        {
            this.Id = Id;
            this.Alias = Alias;
            this.Tipo = Tipo;
            this.Saldo = Saldo;
            Cbu = cbu;
            this.monedaId = monedaId;
        }

        public string mostrarInfo => $"{Id} - {Alias} - {Tipo} - Saldo: ${Saldo} - {Cbu}";

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