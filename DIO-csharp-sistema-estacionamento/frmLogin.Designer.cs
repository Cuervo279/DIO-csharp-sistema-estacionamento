namespace DIO_sistema_estacionamento
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            lblEsqueciSenha = new Label();
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(297, 325);
            panel1.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MediumSeaGreen;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(327, 225);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(236, 32);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(30, 30, 30);
            pictureBox1.Location = new Point(327, 112);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(60, 60, 60);
            pictureBox3.Location = new Point(356, 112);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(207, 30);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(60, 60, 60);
            pictureBox2.Location = new Point(356, 169);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(207, 30);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(30, 30, 30);
            pictureBox4.Location = new Point(327, 169);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 30);
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // lblEsqueciSenha
            // 
            lblEsqueciSenha.AutoSize = true;
            lblEsqueciSenha.Location = new Point(458, 277);
            lblEsqueciSenha.Name = "lblEsqueciSenha";
            lblEsqueciSenha.Size = new Size(105, 15);
            lblEsqueciSenha.TabIndex = 11;
            lblEsqueciSenha.Text = "Esqueceu a senha?";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(327, 273);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(92, 19);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Lembrar-me";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(60, 60, 60);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(360, 119);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 16);
            textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(60, 60, 60);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(360, 176);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 16);
            textBox2.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.Location = new Point(408, 18);
            panel2.Name = "panel2";
            panel2.Size = new Size(80, 80);
            panel2.TabIndex = 15;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 48, 48);
            ClientSize = new Size(593, 322);
            Controls.Add(panel2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(checkBox1);
            Controls.Add(lblEsqueciSenha);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogin);
            Controls.Add(panel1);
            ForeColor = Color.WhiteSmoke;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Button btnLogin;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private Label lblEsqueciSenha;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Panel panel2;
    }
}
