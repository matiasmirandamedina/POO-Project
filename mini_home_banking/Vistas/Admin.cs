using mini_home_banking.Controladores;
using mini_home_banking.Modelos;
using mini_home_banking.Vistas.UserControl;

namespace mini_home_banking.Vistas
{
    public partial class Admin : Form
    {
        private Conexion mConexion;

        private User user;

        public Admin(User user)
        {
            InitializeComponent();
            mConexion = new Conexion();
            this.user = user;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            this.Text = $"Admin - {user.GetUsername()}";
        }

        private void CargarUserControl(System.Windows.Forms.UserControl uc)
        {
            panel1.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc);
        }

        private void insertUserVar_Click(object sender, EventArgs e)
        {
            UC_insertUser uc = new UC_insertUser();
            uc.SetConexion(mConexion);
            CargarUserControl(uc);
        }

        private void insertAccountVar_Click(object sender, EventArgs e)
        {
            UC_insertAccounts uc = new UC_insertAccounts();
            uc.SetConexion(mConexion);
            CargarUserControl(uc);
        }

        private void generateDebitsVar_Click(object sender, EventArgs e)
        {
            UC_generateDebits uc = new UC_generateDebits();
            uc.SetConexion(mConexion);
            CargarUserControl(uc);
        }

        private void summaryCard_Click(object sender, EventArgs e)
        {
            UC_summaryCard uc = new UC_summaryCard();
            uc.SetConexion(mConexion);
            CargarUserControl(uc);
        }

        private void panelVar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}