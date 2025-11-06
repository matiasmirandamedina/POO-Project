using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_home_banking.Controladores
{
    public class Role
    {
        public int id { get; set; }
        public string name { get; set; }

        public Role(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public string mostrarInfo => $"{id} - {name}";
    }
}