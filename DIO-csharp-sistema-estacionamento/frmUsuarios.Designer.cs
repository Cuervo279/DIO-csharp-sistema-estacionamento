namespace DIO_csharp_sistema_estacionamento
{
    partial class frmUsuarios
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
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            btnPesquisa = new Button();
            button1 = new Button();
            btnVoltar = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1020, 500);
            dataGridView1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(112, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(130, 12);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(112, 23);
            dateTimePicker2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiLight", 8.25F);
            label1.Location = new Point(248, 19);
            label1.Name = "label1";
            label1.Size = new Size(47, 13);
            label1.TabIndex = 10;
            label1.Text = "CÓDIGO:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Silver;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(297, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 23);
            textBox1.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiLight", 8.25F);
            label2.Location = new Point(488, 19);
            label2.Name = "label2";
            label2.Size = new Size(40, 13);
            label2.TabIndex = 12;
            label2.Text = "NOME:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Silver;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(532, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(347, 23);
            textBox2.TabIndex = 13;
            // 
            // btnPesquisa
            // 
            btnPesquisa.BackColor = Color.MediumSeaGreen;
            btnPesquisa.FlatAppearance.BorderSize = 0;
            btnPesquisa.FlatStyle = FlatStyle.Flat;
            btnPesquisa.Font = new Font("Bahnschrift SemiLight", 8.25F);
            btnPesquisa.ForeColor = Color.Black;
            btnPesquisa.Location = new Point(885, 12);
            btnPesquisa.Name = "btnPesquisa";
            btnPesquisa.Size = new Size(147, 23);
            btnPesquisa.TabIndex = 14;
            btnPesquisa.Text = "PESQUISA";
            btnPesquisa.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bahnschrift SemiLight", 8.25F);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(579, 557);
            button1.Name = "button1";
            button1.Size = new Size(147, 23);
            button1.TabIndex = 15;
            button1.Text = "EXCLUIR";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.MediumSeaGreen;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Bahnschrift SemiLight", 8.25F);
            btnVoltar.ForeColor = Color.Black;
            btnVoltar.Location = new Point(885, 557);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(147, 23);
            btnVoltar.TabIndex = 16;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumSeaGreen;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Bahnschrift SemiLight", 8.25F);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(732, 557);
            button3.Name = "button3";
            button3.Size = new Size(147, 23);
            button3.TabIndex = 17;
            button3.Text = "CANCELAR";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.MediumSeaGreen;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Bahnschrift SemiLight", 8.25F);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(426, 557);
            button4.Name = "button4";
            button4.Size = new Size(147, 23);
            button4.TabIndex = 18;
            button4.Text = "NOVO";
            button4.UseVisualStyleBackColor = false;
            // 
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(1044, 601);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnVoltar);
            Controls.Add(button1);
            Controls.Add(btnPesquisa);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            ForeColor = Color.WhiteSmoke;
            Name = "frmCadastro";
            Text = "frmCadastro";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Button btnPesquisa;
        private Button button1;
        private Button btnVoltar;
        private Button button3;
        private Button button4;
    }
}