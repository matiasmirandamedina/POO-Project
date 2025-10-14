using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mini_home_banking.Controladores;
using mini_home_banking.Modelos;

namespace mini_home_banking.Vistas
{
    public partial class Transferencia : Form
    {
        private List<Cuenta> cuentas;
        public Transferencia(List<Cuenta> cuentas)
        {
            this.cuentas = cuentas;
            InitializeComponent();
        }

        private void Transferencia_Load(object sender, EventArgs e)
        {
            listBoxCuentas.DataSource = cuentas;
        }
    }
}
