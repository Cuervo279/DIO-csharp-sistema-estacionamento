using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIO_csharp_sistema_estacionamento
{
    public partial class frmDashboard : Form
    {
        private Form formAtivo = null;

        public frmDashboard()
        {
            frmHome home = new();

            InitializeComponent();
            RestaurarPainelPadrao();

            AbrirFormNoPanel(home);
        }

        private void btnMenu_MouseEnter(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            if (botao != null)
            {
                botao.BackColor = Color.MediumSeaGreen;
                botao.ForeColor = Color.Black;
            }
        }

        private void btnMenu_MouseLeave(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            if (botao != null)
            {
                botao.BackColor = Color.FromArgb(30, 30, 30);
                botao.ForeColor = Color.WhiteSmoke;
            }
        }

        private void btnSair_MouseEnter(object sender, EventArgs e)
        {
            btnSair.BackColor = Color.Crimson;
            btnSair.ForeColor = Color.Black;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AbrirFormNoPanel(Form formFilho)
        {
            if (formAtivo != null)
                formAtivo.Close();

            pnlConteudo.Controls.Clear();
            formFilho.TopLevel = false;
            formFilho.FormBorderStyle = FormBorderStyle.None;
            formFilho.Dock = DockStyle.Fill;
            formFilho.FormClosed += (s, e) => RestaurarPainelPadrao();
            pnlConteudo.Controls.Add(formFilho);
            formFilho.Show();
        }

        public void RestaurarPainelPadrao()
        {
            frmEstacionamento home = new();

            pnlConteudo.Controls.Clear();
            home.TopLevel = false;
            home.FormBorderStyle = FormBorderStyle.None;
            home.Dock = DockStyle.Fill;
            pnlConteudo.Controls.Add(home);
            home.Show();
            lblBoardAtiva.Text = btnHome.Text;
        }

        private void btnEstacionamento_Click(object sender, EventArgs e)
        {
            frmEstacionamento estacionamento = new();

            AbrirFormNoPanel(estacionamento);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            if (botao != null)
            {
                lblBoardAtiva.Text = botao.Text;
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {

            frmCadastro cadastro = new();

            AbrirFormNoPanel(cadastro);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome home = new();

            AbrirFormNoPanel(home);

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios usuarios = new();

            AbrirFormNoPanel(usuarios);
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            frmCaixa caixa = new(this);

            AbrirFormNoPanel(caixa);
        }
    }
}
