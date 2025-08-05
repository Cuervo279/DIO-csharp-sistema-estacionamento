namespace DIO_csharp_sistema_estacionamento
{
    partial class frmDashboard
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnSair = new Button();
            btnConfiguracoes = new Button();
            btnCaixa = new Button();
            btnUsuarios = new Button();
            btnCadastro = new Button();
            btn = new Button();
            btnEstacionamento = new Button();
            btnHome = new Button();
            pnlConteudo = new Panel();
            lblBoardAtiva = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 40);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(btnConfiguracoes);
            panel1.Controls.Add(btnCaixa);
            panel1.Controls.Add(btnUsuarios);
            panel1.Controls.Add(btnCadastro);
            panel1.Controls.Add(btn);
            panel1.Controls.Add(btnEstacionamento);
            panel1.Controls.Add(btnHome);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(187, 684);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiLight", 8.25F);
            label1.Location = new Point(3, 659);
            label1.Name = "label1";
            label1.Size = new Size(68, 13);
            label1.TabIndex = 9;
            label1.Text = "Version 0.0.1";
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(181, 78);
            panel2.TabIndex = 8;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(30, 30, 30);
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Bahnschrift SemiLight", 8.25F);
            btnSair.Location = new Point(3, 297);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(181, 28);
            btnSair.TabIndex = 7;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            btnSair.MouseEnter += btnSair_MouseEnter;
            btnSair.MouseLeave += btnMenu_MouseLeave;
            // 
            // btnConfiguracoes
            // 
            btnConfiguracoes.BackColor = Color.FromArgb(30, 30, 30);
            btnConfiguracoes.FlatAppearance.BorderSize = 0;
            btnConfiguracoes.FlatStyle = FlatStyle.Flat;
            btnConfiguracoes.Font = new Font("Bahnschrift SemiLight", 8.25F);
            btnConfiguracoes.Location = new Point(3, 267);
            btnConfiguracoes.Name = "btnConfiguracoes";
            btnConfiguracoes.Size = new Size(181, 28);
            btnConfiguracoes.TabIndex = 6;
            btnConfiguracoes.Text = "CONFIGURAÇÕES";
            btnConfiguracoes.UseVisualStyleBackColor = false;
            btnConfiguracoes.MouseClick += btnMenu_Click;
            btnConfiguracoes.MouseEnter += btnMenu_MouseEnter;
            btnConfiguracoes.MouseLeave += btnMenu_MouseLeave;
            // 
            // btnCaixa
            // 
            btnCaixa.BackColor = Color.FromArgb(30, 30, 30);
            btnCaixa.FlatAppearance.BorderSize = 0;
            btnCaixa.FlatStyle = FlatStyle.Flat;
            btnCaixa.Font = new Font("Bahnschrift SemiLight", 8.25F);
            btnCaixa.Location = new Point(3, 237);
            btnCaixa.Name = "btnCaixa";
            btnCaixa.Size = new Size(181, 28);
            btnCaixa.TabIndex = 5;
            btnCaixa.Text = "CAIXA";
            btnCaixa.UseVisualStyleBackColor = false;
            btnCaixa.Click += btnCaixa_Click;
            btnCaixa.MouseClick += btnMenu_Click;
            btnCaixa.MouseEnter += btnMenu_MouseEnter;
            btnCaixa.MouseLeave += btnMenu_MouseLeave;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.FromArgb(30, 30, 30);
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Bahnschrift SemiLight", 8.25F);
            btnUsuarios.Location = new Point(3, 207);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(181, 28);
            btnUsuarios.TabIndex = 4;
            btnUsuarios.Text = "USUÁRIOS";
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            btnUsuarios.MouseClick += btnMenu_Click;
            btnUsuarios.MouseEnter += btnMenu_MouseEnter;
            btnUsuarios.MouseLeave += btnMenu_MouseLeave;
            // 
            // btnCadastro
            // 
            btnCadastro.BackColor = Color.FromArgb(30, 30, 30);
            btnCadastro.FlatAppearance.BorderSize = 0;
            btnCadastro.FlatStyle = FlatStyle.Flat;
            btnCadastro.Font = new Font("Bahnschrift SemiLight", 8.25F);
            btnCadastro.Location = new Point(3, 177);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(181, 28);
            btnCadastro.TabIndex = 3;
            btnCadastro.Text = "CADASTRO";
            btnCadastro.UseVisualStyleBackColor = false;
            btnCadastro.Click += btnCadastro_Click;
            btnCadastro.MouseClick += btnMenu_Click;
            btnCadastro.MouseEnter += btnMenu_MouseEnter;
            btnCadastro.MouseLeave += btnMenu_MouseLeave;
            // 
            // btn
            // 
            btn.BackColor = Color.FromArgb(30, 30, 30);
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Font = new Font("Bahnschrift SemiLight", 8.25F);
            btn.Location = new Point(3, 147);
            btn.Name = "btn";
            btn.Size = new Size(181, 28);
            btn.TabIndex = 2;
            btn.Text = "MENSALISTA";
            btn.UseVisualStyleBackColor = false;
            btn.MouseClick += btnMenu_Click;
            btn.MouseEnter += btnMenu_MouseEnter;
            btn.MouseLeave += btnMenu_MouseLeave;
            // 
            // btnEstacionamento
            // 
            btnEstacionamento.BackColor = Color.FromArgb(30, 30, 30);
            btnEstacionamento.FlatAppearance.BorderSize = 0;
            btnEstacionamento.FlatStyle = FlatStyle.Flat;
            btnEstacionamento.Font = new Font("Bahnschrift SemiLight", 8.25F);
            btnEstacionamento.Location = new Point(3, 117);
            btnEstacionamento.Name = "btnEstacionamento";
            btnEstacionamento.Size = new Size(181, 28);
            btnEstacionamento.TabIndex = 1;
            btnEstacionamento.Text = "ESTACIONAMENTO";
            btnEstacionamento.UseVisualStyleBackColor = false;
            btnEstacionamento.Click += btnEstacionamento_Click;
            btnEstacionamento.MouseClick += btnMenu_Click;
            btnEstacionamento.MouseEnter += btnMenu_MouseEnter;
            btnEstacionamento.MouseLeave += btnMenu_MouseLeave;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(30, 30, 30);
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Bahnschrift SemiLight", 8.25F);
            btnHome.Location = new Point(3, 87);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(181, 28);
            btnHome.TabIndex = 0;
            btnHome.Text = "HOME";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            btnHome.MouseClick += btnMenu_Click;
            btnHome.MouseEnter += btnMenu_MouseEnter;
            btnHome.MouseLeave += btnMenu_MouseLeave;
            // 
            // pnlConteudo
            // 
            pnlConteudo.Location = new Point(196, 33);
            pnlConteudo.Name = "pnlConteudo";
            pnlConteudo.Size = new Size(1060, 640);
            pnlConteudo.TabIndex = 1;
            // 
            // lblBoardAtiva
            // 
            lblBoardAtiva.AutoSize = true;
            lblBoardAtiva.Font = new Font("Bahnschrift SemiLight", 8.25F);
            lblBoardAtiva.Location = new Point(196, 9);
            lblBoardAtiva.Name = "lblBoardAtiva";
            lblBoardAtiva.Size = new Size(73, 13);
            lblBoardAtiva.TabIndex = 2;
            lblBoardAtiva.Text = "{{TAB ATIVA}}";
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 48, 48);
            ClientSize = new Size(1264, 681);
            Controls.Add(lblBoardAtiva);
            Controls.Add(pnlConteudo);
            Controls.Add(panel1);
            ForeColor = Color.WhiteSmoke;
            Name = "frmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnHome;
        private Panel panel2;
        private Button btnSair;
        private Button btnConfiguracoes;
        private Button btnCaixa;
        private Button btnUsuarios;
        private Button btnCadastro;
        private Button btn;
        private Button btnEstacionamento;
        private Label label1;
        private Panel pnlConteudo;
        private Label lblBoardAtiva;
    }
}