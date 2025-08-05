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
    public partial class frmCaixa : Form
    {
        VendasBll bll = new();


        private frmDashboard dashboard;

        double valorHora = 7.8;


        public frmCaixa(frmDashboard dashboard)
        {
            InitializeComponent();

            this.dashboard = dashboard;

            CarregaElementos();
        }

        private void CarregaElementos()
        {
            lblHorarioEntrada.Text = "07:08";

            lblHorarioSaida.Text = DateTime.Now.ToString("HH:mm");

            cmbFormaPagamento.SelectedIndex = 2;

            CalculaTotal();
        }


        private void CalculaTotal()
        {
            try
            {
                DateTime entrada = Convert.ToDateTime(lblHorarioEntrada.Text);
                DateTime saida = Convert.ToDateTime(lblHorarioSaida.Text);

                TimeSpan duracao = saida - entrada;
                double horas = duracao.TotalHours;

                double resultado = horas * valorHora;

                lblTotalPagar.Text = resultado.ToString("C");
                lblTotalTempo.Text = duracao.ToString(@"hh\:mm");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao calcular total: " + ex.Message);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string cpf = txtPesquisa.Text;

            DataTable dt = bll.preencheUsuarioCaixa(cpf);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                lblCupom.Text = row["vendas_cupom"].ToString();
                lblCodigoUsuario.Text = row["usuario_codigo"].ToString();
                lblHorarioEntrada.Text = Convert.ToDateTime(row["vendas_entrada"]).ToString("HH:mm");
                lblNomeUsuario.Text = row["usuario_nome"].ToString();
                lblStatusUsuario.Text = row["usuario_status"].ToString();
                lblTelefoneUsuario.Text = row["usuario_telefone"].ToString();
            }
            else
            {
                MessageBox.Show("Nenhum usuário encontrado com esse CPF.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
