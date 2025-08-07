namespace DIO_csharp_sistema_estacionamento
{
    partial class frmCaixa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label21 = new Label();
            label1 = new Label();
            txtPesquisa = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            cmbFormaPagamento = new ComboBox();
            lblTotalTempo = new Label();
            lblTotalPagar = new Label();
            lblHorarioEntrada = new Label();
            lblHorarioSaida = new Label();
            lblCupom = new Label();
            lblCodigoUsuario = new Label();
            lblTelefoneUsuario = new Label();
            lblStatusUsuario = new Label();
            lblNomeUsuario = new Label();
            btnOK = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label21
            // 
            label21.Font = new Font("Bahnschrift SemiLight", 10F);
            label21.ForeColor = Color.MediumTurquoise;
            label21.Location = new Point(272, 114);
            label21.Name = "label21";
            label21.Size = new Size(153, 34);
            label21.TabIndex = 16;
            label21.Text = "CÓDIGO USUÁRIO";
            label21.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Font = new Font("Bahnschrift SemiLight", 10F);
            label1.ForeColor = Color.MediumTurquoise;
            label1.Location = new Point(33, 114);
            label1.Name = "label1";
            label1.Size = new Size(153, 34);
            label1.TabIndex = 17;
            label1.Text = "CUPOM";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPesquisa
            // 
            txtPesquisa.BackColor = SystemColors.Control;
            txtPesquisa.BorderStyle = BorderStyle.None;
            txtPesquisa.Font = new Font("Bahnschrift SemiLight", 20F);
            txtPesquisa.Location = new Point(33, 46);
            txtPesquisa.MaxLength = 11;
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(187, 33);
            txtPesquisa.TabIndex = 20;
            txtPesquisa.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.Font = new Font("Bahnschrift SemiLight", 10F);
            label2.ForeColor = Color.MediumTurquoise;
            label2.Location = new Point(33, 9);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(153, 34);
            label2.TabIndex = 19;
            label2.Text = "CPF USUÁRIO";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Bahnschrift SemiLight", 10F);
            label3.ForeColor = Color.MediumTurquoise;
            label3.Location = new Point(272, 232);
            label3.Name = "label3";
            label3.Size = new Size(153, 34);
            label3.TabIndex = 21;
            label3.Text = "HORÁRIO SAÍDA";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Font = new Font("Bahnschrift SemiLight", 10F);
            label5.ForeColor = Color.MediumTurquoise;
            label5.Location = new Point(33, 232);
            label5.Name = "label5";
            label5.Size = new Size(153, 34);
            label5.TabIndex = 23;
            label5.Text = "HORÁRIO ENTRADA";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("Bahnschrift SemiLight", 10F);
            label4.ForeColor = Color.MediumTurquoise;
            label4.Location = new Point(504, 114);
            label4.Name = "label4";
            label4.Size = new Size(153, 34);
            label4.TabIndex = 28;
            label4.Text = "NOME";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Font = new Font("Bahnschrift SemiLight", 10F);
            label7.ForeColor = Color.MediumTurquoise;
            label7.Location = new Point(504, 232);
            label7.Name = "label7";
            label7.Size = new Size(153, 34);
            label7.TabIndex = 29;
            label7.Text = "TELEFONE";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Font = new Font("Bahnschrift SemiLight", 10F);
            label8.ForeColor = Color.MediumTurquoise;
            label8.Location = new Point(744, 232);
            label8.Name = "label8";
            label8.Size = new Size(153, 34);
            label8.TabIndex = 31;
            label8.Text = "STATUS";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.Font = new Font("Bahnschrift SemiLight", 10F);
            label9.ForeColor = Color.MediumTurquoise;
            label9.Location = new Point(33, 366);
            label9.Name = "label9";
            label9.Size = new Size(153, 34);
            label9.TabIndex = 33;
            label9.Text = "TOTAL TEMPO";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.Font = new Font("Bahnschrift SemiLight", 10F);
            label10.ForeColor = Color.MediumTurquoise;
            label10.Location = new Point(272, 366);
            label10.Name = "label10";
            label10.Size = new Size(153, 34);
            label10.TabIndex = 35;
            label10.Text = "TOTAL A PAGAR";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.Font = new Font("Bahnschrift SemiLight", 10F);
            label11.ForeColor = Color.MediumTurquoise;
            label11.Location = new Point(504, 366);
            label11.Name = "label11";
            label11.Size = new Size(187, 34);
            label11.TabIndex = 37;
            label11.Text = "FORMA DE PAGAMENTO";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbFormaPagamento
            // 
            cmbFormaPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFormaPagamento.FlatStyle = FlatStyle.Flat;
            cmbFormaPagamento.Font = new Font("Bahnschrift SemiLight", 16F);
            cmbFormaPagamento.FormattingEnabled = true;
            cmbFormaPagamento.Items.AddRange(new object[] { "DÉBITO", "CRÉDITO", "PIX" });
            cmbFormaPagamento.Location = new Point(504, 406);
            cmbFormaPagamento.Name = "cmbFormaPagamento";
            cmbFormaPagamento.Size = new Size(187, 33);
            cmbFormaPagamento.TabIndex = 39;
            // 
            // lblTotalTempo
            // 
            lblTotalTempo.Font = new Font("Bahnschrift SemiLight", 20F);
            lblTotalTempo.ForeColor = Color.WhiteSmoke;
            lblTotalTempo.Location = new Point(33, 408);
            lblTotalTempo.Name = "lblTotalTempo";
            lblTotalTempo.Padding = new Padding(10, 0, 0, 0);
            lblTotalTempo.Size = new Size(187, 34);
            lblTotalTempo.TabIndex = 40;
            lblTotalTempo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalPagar
            // 
            lblTotalPagar.Font = new Font("Bahnschrift SemiLight", 20F);
            lblTotalPagar.ForeColor = Color.WhiteSmoke;
            lblTotalPagar.Location = new Point(272, 406);
            lblTotalPagar.Name = "lblTotalPagar";
            lblTotalPagar.Padding = new Padding(10, 0, 0, 0);
            lblTotalPagar.RightToLeft = RightToLeft.No;
            lblTotalPagar.Size = new Size(153, 34);
            lblTotalPagar.TabIndex = 41;
            lblTotalPagar.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblHorarioEntrada
            // 
            lblHorarioEntrada.Font = new Font("Bahnschrift SemiLight", 20F);
            lblHorarioEntrada.ForeColor = Color.WhiteSmoke;
            lblHorarioEntrada.Location = new Point(33, 269);
            lblHorarioEntrada.Name = "lblHorarioEntrada";
            lblHorarioEntrada.Padding = new Padding(10, 0, 0, 0);
            lblHorarioEntrada.Size = new Size(187, 34);
            lblHorarioEntrada.TabIndex = 42;
            lblHorarioEntrada.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblHorarioSaida
            // 
            lblHorarioSaida.Font = new Font("Bahnschrift SemiLight", 20F);
            lblHorarioSaida.ForeColor = Color.WhiteSmoke;
            lblHorarioSaida.Location = new Point(272, 269);
            lblHorarioSaida.Name = "lblHorarioSaida";
            lblHorarioSaida.Padding = new Padding(10, 0, 0, 0);
            lblHorarioSaida.Size = new Size(187, 34);
            lblHorarioSaida.TabIndex = 43;
            lblHorarioSaida.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCupom
            // 
            lblCupom.Font = new Font("Bahnschrift SemiLight", 20F);
            lblCupom.ForeColor = Color.WhiteSmoke;
            lblCupom.Location = new Point(33, 151);
            lblCupom.Name = "lblCupom";
            lblCupom.Padding = new Padding(10, 0, 0, 0);
            lblCupom.Size = new Size(187, 34);
            lblCupom.TabIndex = 44;
            lblCupom.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCodigoUsuario
            // 
            lblCodigoUsuario.Font = new Font("Bahnschrift SemiLight", 20F);
            lblCodigoUsuario.ForeColor = Color.WhiteSmoke;
            lblCodigoUsuario.Location = new Point(272, 151);
            lblCodigoUsuario.Name = "lblCodigoUsuario";
            lblCodigoUsuario.Padding = new Padding(10, 0, 0, 0);
            lblCodigoUsuario.Size = new Size(187, 34);
            lblCodigoUsuario.TabIndex = 45;
            lblCodigoUsuario.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTelefoneUsuario
            // 
            lblTelefoneUsuario.Font = new Font("Bahnschrift SemiLight", 20F);
            lblTelefoneUsuario.ForeColor = Color.WhiteSmoke;
            lblTelefoneUsuario.Location = new Point(504, 269);
            lblTelefoneUsuario.Name = "lblTelefoneUsuario";
            lblTelefoneUsuario.Padding = new Padding(10, 0, 0, 0);
            lblTelefoneUsuario.Size = new Size(187, 34);
            lblTelefoneUsuario.TabIndex = 46;
            lblTelefoneUsuario.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStatusUsuario
            // 
            lblStatusUsuario.Font = new Font("Bahnschrift SemiLight", 20F);
            lblStatusUsuario.ForeColor = Color.WhiteSmoke;
            lblStatusUsuario.Location = new Point(710, 269);
            lblStatusUsuario.Name = "lblStatusUsuario";
            lblStatusUsuario.Padding = new Padding(10, 0, 0, 0);
            lblStatusUsuario.Size = new Size(187, 34);
            lblStatusUsuario.TabIndex = 47;
            lblStatusUsuario.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNomeUsuario
            // 
            lblNomeUsuario.Font = new Font("Bahnschrift SemiLight", 20F);
            lblNomeUsuario.ForeColor = Color.WhiteSmoke;
            lblNomeUsuario.Location = new Point(504, 148);
            lblNomeUsuario.Name = "lblNomeUsuario";
            lblNomeUsuario.Padding = new Padding(10, 0, 0, 0);
            lblNomeUsuario.Size = new Size(393, 34);
            lblNomeUsuario.TabIndex = 48;
            lblNomeUsuario.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.MediumSeaGreen;
            btnOK.FlatAppearance.BorderSize = 0;
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.Font = new Font("Bahnschrift SemiLight", 10F);
            btnOK.ForeColor = Color.Black;
            btnOK.Location = new Point(221, 46);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(49, 33);
            btnOK.TabIndex = 49;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Orange;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bahnschrift SemiLight", 10F);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(744, 523);
            button1.Name = "button1";
            button1.Size = new Size(136, 66);
            button1.TabIndex = 50;
            button1.Text = "CANCELAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumSeaGreen;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Bahnschrift SemiLight", 10F);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(894, 523);
            button2.Name = "button2";
            button2.Size = new Size(136, 66);
            button2.TabIndex = 51;
            button2.Text = "CONFIRMAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // frmCaixa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 48, 48);
            ClientSize = new Size(1044, 601);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnOK);
            Controls.Add(lblNomeUsuario);
            Controls.Add(lblStatusUsuario);
            Controls.Add(lblTelefoneUsuario);
            Controls.Add(lblCodigoUsuario);
            Controls.Add(lblCupom);
            Controls.Add(lblHorarioSaida);
            Controls.Add(lblHorarioEntrada);
            Controls.Add(lblTotalPagar);
            Controls.Add(lblTotalTempo);
            Controls.Add(cmbFormaPagamento);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txtPesquisa);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label21);
            ForeColor = Color.WhiteSmoke;
            Name = "frmCaixa";
            Text = "frmCaixa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label21;
        private Label label1;
        private TextBox txtPesquisa;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private ComboBox cmbFormaPagamento;
        private Label lblTotalTempo;
        private Label lblTotalPagar;
        private Label lblHorarioEntrada;
        private Label lblHorarioSaida;
        private Label lblCupom;
        private Label lblCodigoUsuario;
        private Label lblTelefoneUsuario;
        private Label lblStatusUsuario;
        private Label lblNomeUsuario;
        private Button btnOK;
        private Button button1;
        private Button button2;
    }
}