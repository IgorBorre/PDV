namespace PDV
{
    partial class FormasPagamentoNovo
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
            TfDescricao = new TextBox();
            label3 = new Label();
            CbAtiva = new ComboBox();
            label4 = new Label();
            CbAvista = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            BtOk = new Button();
            BtCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 9);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // TfCodigo
            // 
            TfCodigo.Enabled = false;
            TfCodigo.Location = new Point(75, 6);
            TfCodigo.Name = "TfCodigo";
            TfCodigo.Size = new Size(100, 23);
            TfCodigo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 44);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 2;
            label2.Text = "Descrição";
            // 
            // TfDescricao
            // 
            TfDescricao.Location = new Point(75, 41);
            TfDescricao.Name = "TfDescricao";
            TfDescricao.Size = new Size(375, 23);
            TfDescricao.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 85);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 4;
            label3.Text = "Ativa";
            // 
            // CbAtiva
            // 
            CbAtiva.AutoCompleteSource = AutoCompleteSource.ListItems;
            CbAtiva.DropDownStyle = ComboBoxStyle.DropDownList;
            CbAtiva.FormattingEnabled = true;
            CbAtiva.Items.AddRange(new object[] { "Sim", "Não" });
            CbAtiva.Location = new Point(75, 82);
            CbAtiva.Name = "CbAtiva";
            CbAtiva.Size = new Size(121, 23);
            CbAtiva.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 129);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 6;
            label4.Text = "A vista";
            // 
            // CbAvista
            // 
            CbAvista.DropDownStyle = ComboBoxStyle.DropDownList;
            CbAvista.FormattingEnabled = true;
            CbAvista.Items.AddRange(new object[] { "Sim", "Não" });
            CbAvista.Location = new Point(75, 126);
            CbAvista.Name = "CbAvista";
            CbAvista.Size = new Size(121, 23);
            CbAvista.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(57, 44);
            label5.Name = "label5";
            label5.Size = new Size(12, 15);
            label5.TabIndex = 8;
            label5.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(57, 85);
            label6.Name = "label6";
            label6.Size = new Size(12, 15);
            label6.TabIndex = 9;
            label6.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(57, 129);
            label7.Name = "label7";
            label7.Size = new Size(12, 15);
            label7.TabIndex = 10;
            label7.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(465, 310);
            label8.Name = "label8";
            label8.Size = new Size(147, 15);
            label8.TabIndex = 11;
            label8.Text = "* Informações obrigatórias";
            // 
            // BtOk
            // 
            BtOk.Image = Properties.Resources.verifica__2___1_;
            BtOk.ImageAlign = ContentAlignment.MiddleRight;
            BtOk.Location = new Point(15, 302);
            BtOk.Name = "BtOk";
            BtOk.Size = new Size(75, 23);
            BtOk.TabIndex = 12;
            BtOk.Text = "Ok";
            BtOk.UseVisualStyleBackColor = true;
            BtOk.Click += BtOk_Click;
            // 
            // BtCancelar
            // 
            BtCancelar.Image = Properties.Resources.cancelar__1_;
            BtCancelar.ImageAlign = ContentAlignment.MiddleRight;
            BtCancelar.Location = new Point(135, 302);
            BtCancelar.Name = "BtCancelar";
            BtCancelar.Size = new Size(75, 23);
            BtCancelar.TabIndex = 13;
            BtCancelar.Text = "Cancelar";
            BtCancelar.TextAlign = ContentAlignment.MiddleLeft;
            BtCancelar.UseVisualStyleBackColor = true;
            BtCancelar.Click += BtCancelar_Click;
            // 
            // FormasPagamentoNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 334);
            Controls.Add(BtCancelar);
            Controls.Add(BtOk);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(CbAvista);
            Controls.Add(label4);
            Controls.Add(CbAtiva);
            Controls.Add(label3);
            Controls.Add(TfDescricao);
            Controls.Add(label2);
            Controls.Add(TfCodigo);
            Controls.Add(label1);
            Name = "FormasPagamentoNovo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormasPagamentoNovo";
            Load += FormasPagamentoNovo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TfDescricao;
        private Label label3;
        private ComboBox CbAtiva;
        private Label label4;
        private ComboBox CbAvista;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button BtOk;
        private Button BtCancelar;
        public TextBox TfCodigo;
    }
}