using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_home_banking.Controladores
{
    internal class Card
    {
        private string Tipo { get; set; }
        private decimal Dinero_disponible { get; set; }
        private DateTime Expiration { get; set; }

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
