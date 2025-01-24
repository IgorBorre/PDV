namespace PDV
{
    partial class CadastroEstoque
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
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            dataGridView1 = new DataGridView();
            Código = new DataGridViewTextBoxColumn();
            Referência = new DataGridViewTextBoxColumn();
            Descrição = new DataGridViewTextBoxColumn();
            Estoque = new DataGridViewTextBoxColumn();
            Preço = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 18);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(69, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(357, 56);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 2;
            label2.Text = "Descrição";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(421, 53);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(240, 23);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(375, 18);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 4;
            label3.Text = "Grupo";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(421, 15);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(208, 23);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 56);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 6;
            label4.Text = "Referência";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(69, 53);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(174, 23);
            textBox4.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Código, Referência, Descrição, Estoque, Preço });
            dataGridView1.Location = new Point(3, 133);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(938, 554);
            dataGridView1.TabIndex = 8;
            // 
            // Código
            // 
            Código.HeaderText = "Código";
            Código.Name = "Código";
            // 
            // Referência
            // 
            Referência.HeaderText = "Referência";
            Referência.Name = "Referência";
            // 
            // Descrição
            // 
            Descrição.HeaderText = "Descrição";
            Descrição.Name = "Descrição";
            // 
            // Estoque
            // 
            Estoque.HeaderText = "Estoque";
            Estoque.Name = "Estoque";
            // 
            // Preço
            // 
            Preço.HeaderText = "Preço";
            Preço.Name = "Preço";
            // 
            // button1
            // 
            button1.Image = Properties.Resources.publico_alvo__1_;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(835, 10);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "   Procurar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.lixeira_de_reciclagem__1_;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(835, 39);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "  Limpar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Image = Properties.Resources.adicionar_produto__1_;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(835, 68);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 11;
            button3.Text = "Inserir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // CadastroEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 699);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "CadastroEstoque";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroEstoque";
            Load += CadastroEstoque_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Código;
        private DataGridViewTextBoxColumn Referência;
        private DataGridViewTextBoxColumn Descrição;
        private DataGridViewTextBoxColumn Estoque;
        private DataGridViewTextBoxColumn Preço;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}