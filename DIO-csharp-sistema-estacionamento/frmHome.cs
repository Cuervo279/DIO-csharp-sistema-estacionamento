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
using Microsoft.VisualBasic;

namespace DIO_csharp_sistema_estacionamento
{
    public partial class frmHome : Form
    {
        EstacionamentoBll bll = new();

        public frmHome()
        {
            InitializeComponent();
            AtualizaVagas();

        }

        public void AtualizaVagas()
        {
            lblTotalVagas.Text = (bll.quantidadeVagasLivres() + bll.quantidadeVagasOcupadas()).ToString();

            lblVagasLivre.Text     = bll.quantidadeVagasLivres().ToString();
            lblVagasOcupadas.Text  = bll.quantidadeVagasOcupadas().ToString();

            VerificaStatusVaga();
        }

        private void VerificaStatusVaga()
        {
            foreach (Control ctrl in pnlVagasAuto.Controls)
            {
                if (ctrl is Button btn)
                {
                    string nome = btn.Name;

                    string numeroStr = nome.Substring(4);
                    if (int.TryParse(numeroStr, out int numeroVaga))
                    {

                        string status = bll.statusVaga(numeroVaga, "AUTO");

                        if (status == "LIVRE")
                                btn.BackColor = Color.MediumTurquoise;
                        else if (status == "OCUPADA")
                                btn.BackColor = Color.Crimson;
                        else
                                btn.BackColor = Color.Gray;
                        
                    }
                }
            }

            foreach (Control ctrl in pnlVagasMoto.Controls)
            {
                if (ctrl is Button btn)
                {
                    string nome = btn.Name;

                    string numeroStr = nome.Substring(4);
                    if (int.TryParse(numeroStr, out int numeroVaga))
                    {

                        string status = bll.statusVaga(numeroVaga, "MOTO");

                        if (status == "LIVRE")
                            btn.BackColor = Color.MediumSeaGreen;
                        else if (status == "OCUPADA")
                            btn.BackColor = Color.Crimson;
                        else
                            btn.BackColor = Color.Gray;

                    }
                }
            }
        }
    }
}
