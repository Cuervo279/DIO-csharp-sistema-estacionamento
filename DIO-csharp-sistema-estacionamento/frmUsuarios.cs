using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DIO_csharp_sistema_estacionamento.code.bll;

namespace DIO_csharp_sistema_estacionamento
{
    public partial class frmUsuarios : Form
    {
        UsuariosBll bll = new();


        public frmUsuarios()
        {
            InitializeComponent();
            CarregaGridUsuario();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void CarregaGridUsuario()
        {
            dgvUsuarios.DataSource = bll.CarregaGridUsuario();
            dgvUsuarios.ForeColor = Color.Black;
        }

    }
}
