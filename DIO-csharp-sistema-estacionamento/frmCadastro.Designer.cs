namespace DIO_csharp_sistema_estacionamento
{
    partial class frmCadastro
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
            lblCodigo = new Label();
            textBox2 = new TextBox();
            txtCodigo = new TextBox();
            label1 = new Label();
            lblSenha = new Panel();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            label11 = new Label();
            comboBox3 = new ComboBox();
            label10 = new Label();
            comboBox2 = new ComboBox();
            label9 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label8 = new Label();
            label6 = new Label();
            lblConfirmaSenha = new Label();
            label5 = new Label();
            txtConfirmaSenha = new TextBox();
            label3 = new Label();
            txtSenha = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            tabControl1 = new TabControl();
            Veiculo1 = new TabPage();
            pnlPlacaAntiga = new Panel();
            panel4 = new Panel();
            lblDigitosPlacaAntiga = new Label();
            label17 = new Label();
            pnlMercosulFundo = new Panel();
            pnlMercosulBase = new Panel();
            lblDigitosPlaca = new Label();
            lblMercosulBR = new Label();
            panel2 = new Panel();
            label18 = new Label();
            label15 = new Label();
            cmbCategoria = new ComboBox();
            label13 = new Label();
            cmbModeloPlaca = new ComboBox();
            label14 = new Label();
            comboBox6 = new ComboBox();
            label12 = new Label();
            comboBox4 = new ComboBox();
            label7 = new Label();
            comboBox1 = new ComboBox();
            Veiculo2 = new TabPage();
            Veiculo3 = new TabPage();
            Veiculo4 = new TabPage();
            lblSenha.SuspendLayout();
            tabControl1.SuspendLayout();
            Veiculo1.SuspendLayout();
            pnlPlacaAntiga.SuspendLayout();
            panel4.SuspendLayout();
            pnlMercosulFundo.SuspendLayout();
            pnlMercosulBase.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(13, 14);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 7;
            lblCodigo.Text = "Código";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(13, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(417, 23);
            textBox2.TabIndex = 10;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(13, 32);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(187, 23);
            txtCodigo.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 67);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 9;
            label1.Text = "Nome:";
            // 
            // lblSenha
            // 
            lblSenha.Controls.Add(maskedTextBox3);
            lblSenha.Controls.Add(maskedTextBox2);
            lblSenha.Controls.Add(label11);
            lblSenha.Controls.Add(comboBox3);
            lblSenha.Controls.Add(label10);
            lblSenha.Controls.Add(comboBox2);
            lblSenha.Controls.Add(label9);
            lblSenha.Controls.Add(maskedTextBox1);
            lblSenha.Controls.Add(label8);
            lblSenha.Controls.Add(label6);
            lblSenha.Controls.Add(lblConfirmaSenha);
            lblSenha.Controls.Add(label5);
            lblSenha.Controls.Add(txtConfirmaSenha);
            lblSenha.Controls.Add(label3);
            lblSenha.Controls.Add(txtSenha);
            lblSenha.Controls.Add(label4);
            lblSenha.Controls.Add(textBox5);
            lblSenha.Controls.Add(label2);
            lblSenha.Controls.Add(textBox3);
            lblSenha.Controls.Add(lblCodigo);
            lblSenha.Controls.Add(label1);
            lblSenha.Controls.Add(textBox2);
            lblSenha.Controls.Add(txtCodigo);
            lblSenha.Location = new Point(14, 35);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(671, 241);
            lblSenha.TabIndex = 11;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(163, 196);
            maskedTextBox3.Mask = "00/00/0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(121, 23);
            maskedTextBox3.TabIndex = 33;
            maskedTextBox3.TextAlign = HorizontalAlignment.Center;
            maskedTextBox3.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(13, 196);
            maskedTextBox2.Mask = "999.999.999-99";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(133, 23);
            maskedTextBox2.TabIndex = 32;
            maskedTextBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(163, 178);
            label11.Name = "label11";
            label11.Size = new Size(81, 15);
            label11.TabIndex = 31;
            label11.Text = "Data Cadastro";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(302, 196);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(128, 23);
            comboBox3.TabIndex = 29;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(302, 178);
            label10.Name = "label10";
            label10.Size = new Size(30, 15);
            label10.TabIndex = 28;
            label10.Text = "Tipo";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "SIM", "NÃO" });
            comboBox2.Location = new Point(445, 196);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(101, 23);
            comboBox2.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(445, 178);
            label9.Name = "label9";
            label9.Size = new Size(35, 15);
            label9.TabIndex = 26;
            label9.Text = "Ativo";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(445, 144);
            maskedTextBox1.Mask = "(99) 00000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(101, 23);
            maskedTextBox1.TabIndex = 25;
            maskedTextBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(445, 126);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 24;
            label8.Text = "Telefone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 178);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 20;
            label6.Text = "CPF";
            // 
            // lblConfirmaSenha
            // 
            lblConfirmaSenha.AutoSize = true;
            lblConfirmaSenha.Location = new Point(445, 111);
            lblConfirmaSenha.Name = "lblConfirmaSenha";
            lblConfirmaSenha.Size = new Size(54, 15);
            lblConfirmaSenha.TabIndex = 19;
            lblConfirmaSenha.Text = "{{senha}}";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(445, 67);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 17;
            label5.Text = "Confirme a Senha";
            // 
            // txtConfirmaSenha
            // 
            txtConfirmaSenha.Location = new Point(445, 85);
            txtConfirmaSenha.Name = "txtConfirmaSenha";
            txtConfirmaSenha.Size = new Size(214, 23);
            txtConfirmaSenha.TabIndex = 18;
            txtConfirmaSenha.TextChanged += txtConfirmaSenha_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(445, 14);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 15;
            label3.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(445, 32);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(214, 23);
            txtSenha.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(216, 14);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 13;
            label4.Text = "Usuário";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(216, 32);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(214, 23);
            textBox5.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 125);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 11;
            label2.Text = "Email";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(13, 143);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(417, 23);
            textBox3.TabIndex = 12;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Veiculo1);
            tabControl1.Controls.Add(Veiculo2);
            tabControl1.Controls.Add(Veiculo3);
            tabControl1.Controls.Add(Veiculo4);
            tabControl1.Location = new Point(14, 282);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(671, 218);
            tabControl1.TabIndex = 12;
            // 
            // Veiculo1
            // 
            Veiculo1.BackColor = Color.FromArgb(48, 48, 48);
            Veiculo1.Controls.Add(pnlPlacaAntiga);
            Veiculo1.Controls.Add(pnlMercosulFundo);
            Veiculo1.Controls.Add(label15);
            Veiculo1.Controls.Add(cmbCategoria);
            Veiculo1.Controls.Add(label13);
            Veiculo1.Controls.Add(cmbModeloPlaca);
            Veiculo1.Controls.Add(label14);
            Veiculo1.Controls.Add(comboBox6);
            Veiculo1.Controls.Add(label12);
            Veiculo1.Controls.Add(comboBox4);
            Veiculo1.Controls.Add(label7);
            Veiculo1.Controls.Add(comboBox1);
            Veiculo1.Location = new Point(4, 24);
            Veiculo1.Name = "Veiculo1";
            Veiculo1.Padding = new Padding(3);
            Veiculo1.Size = new Size(663, 190);
            Veiculo1.TabIndex = 0;
            Veiculo1.Text = "Veiculo 1";
            // 
            // pnlPlacaAntiga
            // 
            pnlPlacaAntiga.BackColor = Color.Black;
            pnlPlacaAntiga.Controls.Add(panel4);
            pnlPlacaAntiga.Location = new Point(609, 92);
            pnlPlacaAntiga.Name = "pnlPlacaAntiga";
            pnlPlacaAntiga.Size = new Size(259, 74);
            pnlPlacaAntiga.TabIndex = 31;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkGray;
            panel4.Controls.Add(lblDigitosPlacaAntiga);
            panel4.Controls.Add(label17);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(253, 68);
            panel4.TabIndex = 3;
            // 
            // lblDigitosPlacaAntiga
            // 
            lblDigitosPlacaAntiga.Font = new Font("Miriam Libre", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDigitosPlacaAntiga.ForeColor = Color.Black;
            lblDigitosPlacaAntiga.Location = new Point(26, 25);
            lblDigitosPlacaAntiga.Name = "lblDigitosPlacaAntiga";
            lblDigitosPlacaAntiga.Size = new Size(202, 44);
            lblDigitosPlacaAntiga.TabIndex = 3;
            lblDigitosPlacaAntiga.Text = "ABC-1234";
            lblDigitosPlacaAntiga.TextAlign = ContentAlignment.MiddleCenter;
            lblDigitosPlacaAntiga.Click += lblDigitosPlacaAntiga_Click;
            // 
            // label17
            // 
            label17.BackColor = Color.Silver;
            label17.BorderStyle = BorderStyle.FixedSingle;
            label17.Font = new Font("Candara", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(26, 4);
            label17.Name = "label17";
            label17.Size = new Size(202, 21);
            label17.TabIndex = 0;
            label17.Text = "SP - SÃO PAULO";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlMercosulFundo
            // 
            pnlMercosulFundo.BackColor = Color.Black;
            pnlMercosulFundo.Controls.Add(pnlMercosulBase);
            pnlMercosulFundo.Controls.Add(panel2);
            pnlMercosulFundo.Location = new Point(344, 92);
            pnlMercosulFundo.Name = "pnlMercosulFundo";
            pnlMercosulFundo.Size = new Size(259, 74);
            pnlMercosulFundo.TabIndex = 30;
            // 
            // pnlMercosulBase
            // 
            pnlMercosulBase.BackColor = Color.WhiteSmoke;
            pnlMercosulBase.Controls.Add(lblDigitosPlaca);
            pnlMercosulBase.Controls.Add(lblMercosulBR);
            pnlMercosulBase.Location = new Point(3, 22);
            pnlMercosulBase.Name = "pnlMercosulBase";
            pnlMercosulBase.Size = new Size(253, 49);
            pnlMercosulBase.TabIndex = 3;
            // 
            // lblDigitosPlaca
            // 
            lblDigitosPlaca.Font = new Font("Miriam Libre", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDigitosPlaca.ForeColor = Color.Black;
            lblDigitosPlaca.Location = new Point(29, 0);
            lblDigitosPlaca.Name = "lblDigitosPlaca";
            lblDigitosPlaca.Size = new Size(197, 47);
            lblDigitosPlaca.TabIndex = 3;
            lblDigitosPlaca.Text = "ABC1B34";
            lblDigitosPlaca.TextAlign = ContentAlignment.MiddleCenter;
            lblDigitosPlaca.Click += lblDigitosPlaca_Click;
            // 
            // lblMercosulBR
            // 
            lblMercosulBR.AutoSize = true;
            lblMercosulBR.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMercosulBR.ForeColor = Color.Black;
            lblMercosulBR.Location = new Point(1, 32);
            lblMercosulBR.Name = "lblMercosulBR";
            lblMercosulBR.Size = new Size(23, 15);
            lblMercosulBR.TabIndex = 2;
            lblMercosulBR.Text = "BR";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Blue;
            panel2.Controls.Add(label18);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(253, 22);
            panel2.TabIndex = 2;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.WhiteSmoke;
            label18.Location = new Point(101, 2);
            label18.Name = "label18";
            label18.Size = new Size(53, 14);
            label18.TabIndex = 0;
            label18.Text = "BRASIL";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(484, 20);
            label15.Name = "label15";
            label15.Size = new Size(58, 15);
            label15.TabIndex = 29;
            label15.Text = "Categoria";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "PARTICULAR", "COMERCIAL", "COLECIONADOR", "OFICIAL", "DIPLOMÁTICO", "ESPECIAL" });
            cmbCategoria.Location = new Point(489, 38);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(166, 23);
            cmbCategoria.TabIndex = 28;
            cmbCategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(298, 20);
            label13.Name = "label13";
            label13.Size = new Size(79, 15);
            label13.TabIndex = 27;
            label13.Text = "Modelo Placa";
            // 
            // cmbModeloPlaca
            // 
            cmbModeloPlaca.FormattingEnabled = true;
            cmbModeloPlaca.Items.AddRange(new object[] { "MERCOSUL (NOVA)", "PADRÃO BRASIL" });
            cmbModeloPlaca.Location = new Point(298, 38);
            cmbModeloPlaca.Name = "cmbModeloPlaca";
            cmbModeloPlaca.Size = new Size(178, 23);
            cmbModeloPlaca.TabIndex = 26;
            cmbModeloPlaca.SelectedIndexChanged += cmbModeloPlaca_SelectedIndexChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(9, 126);
            label14.Name = "label14";
            label14.Size = new Size(26, 15);
            label14.TabIndex = 25;
            label14.Text = "Cor";
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(9, 144);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(271, 23);
            comboBox6.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(9, 74);
            label12.Name = "label12";
            label12.Size = new Size(48, 15);
            label12.TabIndex = 23;
            label12.Text = "Modelo";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(9, 92);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(271, 23);
            comboBox4.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 20);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 21;
            label7.Text = "Marca";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(9, 38);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(271, 23);
            comboBox1.TabIndex = 0;
            // 
            // Veiculo2
            // 
            Veiculo2.Location = new Point(4, 24);
            Veiculo2.Name = "Veiculo2";
            Veiculo2.Padding = new Padding(3);
            Veiculo2.Size = new Size(663, 190);
            Veiculo2.TabIndex = 1;
            Veiculo2.Text = "Veiculo 2";
            Veiculo2.UseVisualStyleBackColor = true;
            // 
            // Veiculo3
            // 
            Veiculo3.Location = new Point(4, 24);
            Veiculo3.Name = "Veiculo3";
            Veiculo3.Padding = new Padding(3);
            Veiculo3.Size = new Size(663, 190);
            Veiculo3.TabIndex = 2;
            Veiculo3.Text = "Veiculo 3";
            Veiculo3.UseVisualStyleBackColor = true;
            // 
            // Veiculo4
            // 
            Veiculo4.Location = new Point(4, 24);
            Veiculo4.Name = "Veiculo4";
            Veiculo4.Padding = new Padding(3);
            Veiculo4.Size = new Size(663, 190);
            Veiculo4.TabIndex = 3;
            Veiculo4.Text = "Veiculo 4";
            Veiculo4.UseVisualStyleBackColor = true;
            // 
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 48, 48);
            ClientSize = new Size(697, 523);
            Controls.Add(tabControl1);
            Controls.Add(lblSenha);
            ForeColor = Color.WhiteSmoke;
            Name = "frmCadastro";
            Text = "frmCadastro";
            Load += frmCadastro_Load;
            lblSenha.ResumeLayout(false);
            lblSenha.PerformLayout();
            tabControl1.ResumeLayout(false);
            Veiculo1.ResumeLayout(false);
            Veiculo1.PerformLayout();
            pnlPlacaAntiga.ResumeLayout(false);
            panel4.ResumeLayout(false);
            pnlMercosulFundo.ResumeLayout(false);
            pnlMercosulBase.ResumeLayout(false);
            pnlMercosulBase.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblCodigo;
        private TextBox textBox2;
        private TextBox txtCodigo;
        private Label label1;
        private Panel lblSenha;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox txtSenha;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private TextBox txtConfirmaSenha;
        private Label lblConfirmaSenha;
        private Label label6;
        private ComboBox comboBox2;
        private Label label9;
        private MaskedTextBox maskedTextBox1;
        private Label label8;
        private MaskedTextBox maskedTextBox2;
        private Label label11;
        private ComboBox comboBox3;
        private Label label10;
        private MaskedTextBox maskedTextBox3;
        private TabControl tabControl1;
        private TabPage Veiculo1;
        private TabPage Veiculo2;
        private TabPage Veiculo3;
        private TabPage Veiculo4;
        private ComboBox comboBox1;
        private Label label13;
        private ComboBox cmbModeloPlaca;
        private Label label14;
        private ComboBox comboBox6;
        private Label label12;
        private ComboBox comboBox4;
        private Label label7;
        private Label label15;
        private ComboBox cmbCategoria;
        private Panel pnlMercosulFundo;
        private Panel pnlMercosulBase;
        private Label lblDigitosPlaca;
        private Label lblMercosulBR;
        private Panel panel2;
        private Label label18;
        private Panel pnlPlacaAntiga;
        private Panel panel4;
        private Label lblDigitosPlacaAntiga;
        private Label label17;
    }
}