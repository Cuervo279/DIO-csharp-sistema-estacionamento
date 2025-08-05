using DIO_csharp_sistema_estacionamento;

namespace DIO_sistema_estacionamento
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmDashboard dashboard = new();

            dashboard.ShowDialog();
        }
    }
}
