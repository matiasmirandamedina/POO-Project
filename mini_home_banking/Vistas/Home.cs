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

namespace mini_home_banking.Vistas
{
    public partial class Home : Form
    {
        private Usuario user;
        public Home(Usuario user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
