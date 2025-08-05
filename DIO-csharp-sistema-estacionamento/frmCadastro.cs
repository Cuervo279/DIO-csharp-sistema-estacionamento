using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace DIO_csharp_sistema_estacionamento
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();

            pnlMercosulFundo.Visible = false;
        }

        private void txtConfirmaSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmaSenha.Text != txtSenha.Text)
            {
                lblConfirmaSenha.Text = "As Senhas devem ser iguais!";
                lblConfirmaSenha.ForeColor = Color.Crimson;
            }
            else
            {
                lblConfirmaSenha.Text = "Senhas iguais!";
                lblConfirmaSenha.ForeColor = Color.MediumSeaGreen;
            }

        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            cmbModeloPlaca.SelectedIndex = 0;
            cmbCategoria.SelectedIndex = 0;
        }

        private void cmbModeloPlaca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbModeloPlaca.SelectedIndex == 0)
            {
                pnlMercosulFundo.Visible = true;
                pnlPlacaAntiga.Visible = false;
            }

            if (cmbModeloPlaca.SelectedIndex == 1)
            {
                pnlMercosulFundo.Visible = false;
                pnlPlacaAntiga.Visible = true;
                pnlPlacaAntiga.Location = new Point(344, 92);
            }
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbCategoria.SelectedIndex)
            {
                case (0):
                    pnlMercosulFundo.BackColor = Color.Black;
                    pnlMercosulBase.BackColor = Color.WhiteSmoke;
                    lblDigitosPlaca.ForeColor = Color.Black;
                    lblMercosulBR.ForeColor = Color.Black;
                    break;
                case (1):
                    pnlMercosulFundo.BackColor = Color.Red;
                    pnlMercosulBase.BackColor = Color.WhiteSmoke;
                    lblDigitosPlaca.ForeColor = Color.Red;
                    lblMercosulBR.ForeColor = Color.Black;
                    break;
                case (2):
                    pnlMercosulFundo.BackColor = Color.Black;
                    pnlMercosulBase.BackColor = Color.Black;
                    lblDigitosPlaca.ForeColor = Color.WhiteSmoke;
                    lblMercosulBR.ForeColor = Color.WhiteSmoke;
                    break;
                case (3):
                    pnlMercosulFundo.BackColor = Color.Navy;
                    pnlMercosulBase.BackColor = Color.WhiteSmoke;
                    lblDigitosPlaca.ForeColor = Color.Navy;
                    lblMercosulBR.ForeColor = Color.Black;
                    break;
                case (4):
                    pnlMercosulFundo.BackColor = Color.Orange;
                    pnlMercosulBase.BackColor = Color.WhiteSmoke;
                    lblDigitosPlaca.ForeColor = Color.Orange;
                    lblMercosulBR.ForeColor = Color.Black;
                    break;
                case (5):
                    pnlMercosulFundo.BackColor = Color.SeaGreen;
                    pnlMercosulBase.BackColor = Color.WhiteSmoke;
                    lblDigitosPlaca.ForeColor = Color.SeaGreen;
                    lblMercosulBR.ForeColor = Color.Black;
                    break;
            }
        }

        private void lblDigitosPlaca_Click(object sender, EventArgs e)
        {
            string resposta = Interaction.InputBox("Digite a placa do veículo:", "Entrada de Placa", lblDigitosPlaca.Text);
            if (!string.IsNullOrWhiteSpace(resposta))
            {
                lblDigitosPlaca.Text = resposta.ToUpper();
            }



        }

        private void lblDigitosPlacaAntiga_Click(object sender, EventArgs e)
        {
            string resposta = Interaction.InputBox("Digite a placa do veículo:", "Entrada de Placa", lblDigitosPlacaAntiga.Text);
            if (!string.IsNullOrWhiteSpace(resposta))
            {
                lblDigitosPlacaAntiga.Text = resposta.ToUpper();
            }
        }
    }
}