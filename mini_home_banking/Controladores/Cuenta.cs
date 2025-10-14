using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_home_banking.Controladores
{
    public class Cuenta
    {
        private string Alias { get; set; }
        private string Tipo { get; set; }
        private decimal Saldo { get; set; }

        private string Cbu { get; set; }

        public Cuenta(string Alias, string Tipo, decimal Saldo, string cbu)
        {
            this.Alias = Alias;
            this.Tipo = Tipo;
            this.Saldo = Saldo;
            Cbu = cbu;
        }

        public override string ToString()
        {
            // Esto define lo que se muestra en la ListBox
            return $"{Alias} - {Tipo} - ${Saldo}";
        }
    }
}
