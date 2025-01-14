namespace PDV
{
    partial class CadastroGeral
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
            label1 = new Label();
            TFCodigo = new TextBox();
            label2 = new Label();
            TFNome = new TextBox();
            label3 = new Label();
            TFCpf = new TextBox();
            label4 = new Label();
            TFTelefone = new MaskedTextBox();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            Código = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            CPF = new DataGridViewTextBoxColumn();
            Telefone = new DataGridViewTextBoxColumn();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 31);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // TFCodigo
            // 
            TFCodigo.Location = new Point(72, 28);
            TFCodigo.Name = "TFCodigo";
            TFCodigo.Size = new Size(66, 23);
            TFCodigo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 66);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // TFNome
            // 
            TFNome.Location = new Point(72, 66);
            TFNome.Name = "TFNome";
            TFNome.Size = new Size(258, 23);
            TFNome.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(412, 69);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 4;
            label3.Text = "CPF/CNPJ";
            // 
            // TFCpf
            // 
            TFCpf.Location = new Point(481, 66);
            TFCpf.Name = "TFCpf";
            TFCpf.Size = new Size(193, 23);
            TFCpf.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(424, 31);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 6;
            label4.Text = "Telefone";
            // 
            // TFTelefone
            // 
            TFTelefone.Location = new Point(481, 28);
            TFTelefone.Mask = "(00) 0000-0000";
            TFTelefone.Name = "TFTelefone";
            TFTelefone.Size = new Size(85, 23);
            TFTelefone.TabIndex = 7;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.publico_alvo__1_;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(822, 12);
            button1.Name = "button1";
            button1.Size = new Size(84, 23);
            button1.TabIndex = 8;
            button1.Text = "  Procurar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.lixeira_de_reciclagem__1_;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(822, 41);
            button2.Name = "button2";
            button2.Size = new Size(84, 23);
            button2.TabIndex = 9;
            button2.Text = " Limpar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Código, Nome, CPF, Telefone });
            dataGridView1.Location = new Point(10, 128);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(931, 535);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Código
            // 
            Código.HeaderText = "Código";
            Código.Name = "Código";
            Código.ReadOnly = true;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // CPF
            // 
            CPF.HeaderText = "CPF/CNPJ";
            CPF.Name = "CPF";
            CPF.ReadOnly = true;
            // 
            // Telefone
            // 
            Telefone.HeaderText = "Telefone";
            Telefone.Name = "Telefone";
            Telefone.ReadOnly = true;
            // 
            // button3
            // 
            button3.Image = Properties.Resources.adicionar_usuario__1_1;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(822, 70);
            button3.Name = "button3";
            button3.Size = new Size(84, 23);
            button3.TabIndex = 11;
            button3.Text = "Inserir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // CadastroGeral
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 699);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(TFTelefone);
            Controls.Add(label4);
            Controls.Add(TFCpf);
            Controls.Add(label3);
            Controls.Add(TFNome);
            Controls.Add(label2);
            Controls.Add(TFCodigo);
            Controls.Add(label1);
            Name = "CadastroGeral";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroGeral";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TFCodigo;
        private Label label2;
        private TextBox TFNome;
        private Label label3;
        private TextBox TFCpf;
        private Label label4;
        private MaskedTextBox TFTelefone;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Código;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn CPF;
        private DataGridViewTextBoxColumn Telefone;
        private Button button3;
    }
}