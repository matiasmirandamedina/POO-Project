using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_home_banking.Controladores
{
    public class Own_Exception : ApplicationException
    {
        public Own_Exception() { }

        public Own_Exception(string mensaje) : base(mensaje) { }

        public Own_Exception(string mensaje, Exception inner) : base(mensaje, inner) { }
    }
}
