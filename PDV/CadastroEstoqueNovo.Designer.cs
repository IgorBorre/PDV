namespace PDV
{
    partial class CadastroEstoqueNovo
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
            TfCodigo = new TextBox();
            label2 = new Label();
            TfReferencia = new TextBox();
            label3 = new Label();
            TfDescricao = new TextBox();
            label4 = new Label();
            TfGrupo = new TextBox();
            label5 = new Label();
            TfEstoque = new TextBox();
            label6 = new Label();
            TfPreco = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 14);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // TfCodigo
            // 
            TfCodigo.Enabled = false;
            TfCodigo.Location = new Point(82, 6);
            TfCodigo.Name = "TfCodigo";
            TfCodigo.Size = new Size(100, 23);
            TfCodigo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 50);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "Referência";
            // 
            // TfReferencia
            // 
            TfReferencia.Location = new Point(82, 42);
            TfReferencia.Name = "TfReferencia";
            TfReferencia.Size = new Size(463, 23);
            TfReferencia.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 86);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 4;
            label3.Text = "Descrição";
            // 
            // TfDescricao
            // 
            TfDescricao.Location = new Point(82, 78);
            TfDescricao.Name = "TfDescricao";
            TfDescricao.Size = new Size(463, 23);
            TfDescricao.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 121);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 6;
            label4.Text = "Grupo";
            // 
            // TfGrupo
            // 
            TfGrupo.Location = new Point(82, 113);
            TfGrupo.Name = "TfGrupo";
            TfGrupo.Size = new Size(247, 23);
            TfGrupo.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 160);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 8;
            label5.Text = "Estoque";
            // 
            // TfEstoque
            // 
            TfEstoque.Location = new Point(82, 152);
            TfEstoque.Name = "TfEstoque";
            TfEstoque.Size = new Size(100, 23);
            TfEstoque.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 198);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 10;
            label6.Text = "Preço";
            // 
            // TfPreco
            // 
            TfPreco.Location = new Point(82, 190);
            TfPreco.Name = "TfPreco";
            TfPreco.Size = new Size(100, 23);
            TfPreco.TabIndex = 11;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.verifica__2___1_;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(30, 370);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.cancelar__1_;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(150, 370);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 13;
            button2.Text = "    Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(64, 86);
            label7.Name = "label7";
            label7.Size = new Size(12, 15);
            label7.TabIndex = 14;
            label7.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(54, 160);
            label8.Name = "label8";
            label8.Size = new Size(12, 15);
            label8.TabIndex = 15;
            label8.Text = "*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(41, 198);
            label9.Name = "label9";
            label9.Size = new Size(12, 15);
            label9.TabIndex = 16;
            label9.Text = "*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(317, 370);
            label10.Name = "label10";
            label10.Size = new Size(126, 15);
            label10.TabIndex = 17;
            label10.Text = "* Campos obrigatórios";
            // 
            // CadastroEstoqueNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 406);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(TfPreco);
            Controls.Add(label6);
            Controls.Add(TfEstoque);
            Controls.Add(label5);
            Controls.Add(TfGrupo);
            Controls.Add(label4);
            Controls.Add(TfDescricao);
            Controls.Add(label3);
            Controls.Add(TfReferencia);
            Controls.Add(label2);
            Controls.Add(TfCodigo);
            Controls.Add(label1);
            Name = "CadastroEstoqueNovo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroEstoqueNovo";
            Load += CadastroEstoqueNovo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TfReferencia;
        private Label label3;
        private TextBox TfDescricao;
        private Label label4;
        private TextBox TfGrupo;
        private Label label5;
        private TextBox TfEstoque;
        private Label label6;
        private TextBox TfPreco;
        private Button button1;
        private Button button2;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        public TextBox TfCodigo;
    }
}