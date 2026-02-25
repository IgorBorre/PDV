namespace PDV
{
    partial class LancamentodeDevolucao
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
            groupBox1 = new GroupBox();
            LbDescricao = new Label();
            LbReferencia = new Label();
            LbCodigo = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            BtConfirmar = new Button();
            TfQuantidade = new TextBox();
            label2 = new Label();
            BtProcura = new Button();
            TfProduto = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            referencia = new DataGridViewTextBoxColumn();
            descricao = new DataGridViewTextBoxColumn();
            quantidade = new DataGridViewTextBoxColumn();
            BtFinalizar = new Button();
            BtOriginais = new Button();
            BtLimpar = new Button();
            BtCancelar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LbDescricao);
            groupBox1.Controls.Add(LbReferencia);
            groupBox1.Controls.Add(LbCodigo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(BtConfirmar);
            groupBox1.Controls.Add(TfQuantidade);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(BtProcura);
            groupBox1.Controls.Add(TfProduto);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(891, 132);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações do item da devolução";
            // 
            // LbDescricao
            // 
            LbDescricao.AutoSize = true;
            LbDescricao.Location = new Point(77, 111);
            LbDescricao.Name = "LbDescricao";
            LbDescricao.Size = new Size(0, 15);
            LbDescricao.TabIndex = 11;
            // 
            // LbReferencia
            // 
            LbReferencia.AutoSize = true;
            LbReferencia.Location = new Point(77, 96);
            LbReferencia.Name = "LbReferencia";
            LbReferencia.Size = new Size(0, 15);
            LbReferencia.TabIndex = 10;
            // 
            // LbCodigo
            // 
            LbCodigo.AutoSize = true;
            LbCodigo.Location = new Point(77, 81);
            LbCodigo.Name = "LbCodigo";
            LbCodigo.Size = new Size(0, 15);
            LbCodigo.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 111);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 8;
            label5.Text = "Descrição";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 96);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 7;
            label4.Text = "Referência";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 81);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 6;
            label3.Text = "Código";
            // 
            // BtConfirmar
            // 
            BtConfirmar.Image = Properties.Resources.verifica__2___1_;
            BtConfirmar.ImageAlign = ContentAlignment.MiddleRight;
            BtConfirmar.Location = new Point(539, 42);
            BtConfirmar.Name = "BtConfirmar";
            BtConfirmar.Size = new Size(84, 23);
            BtConfirmar.TabIndex = 5;
            BtConfirmar.Text = "Confirmar";
            BtConfirmar.TextAlign = ContentAlignment.MiddleLeft;
            BtConfirmar.UseVisualStyleBackColor = true;
            // 
            // TfQuantidade
            // 
            TfQuantidade.Location = new Point(408, 43);
            TfQuantidade.Name = "TfQuantidade";
            TfQuantidade.Size = new Size(100, 23);
            TfQuantidade.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(408, 25);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "Quantidade";
            // 
            // BtProcura
            // 
            BtProcura.Image = Properties.Resources.lupa_de_pesquisa__1___1___1_;
            BtProcura.Location = new Point(359, 40);
            BtProcura.Name = "BtProcura";
            BtProcura.Size = new Size(32, 26);
            BtProcura.TabIndex = 2;
            BtProcura.UseVisualStyleBackColor = true;
            // 
            // TfProduto
            // 
            TfProduto.Location = new Point(10, 43);
            TfProduto.Name = "TfProduto";
            TfProduto.Size = new Size(343, 23);
            TfProduto.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 25);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Produto";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { codigo, referencia, descricao, quantidade });
            dataGridView1.Location = new Point(3, 144);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(891, 327);
            dataGridView1.TabIndex = 1;
            // 
            // codigo
            // 
            codigo.FillWeight = 56.1634941F;
            codigo.HeaderText = "Código";
            codigo.Name = "codigo";
            // 
            // referencia
            // 
            referencia.FillWeight = 121.8274F;
            referencia.HeaderText = "Referência";
            referencia.Name = "referencia";
            // 
            // descricao
            // 
            descricao.FillWeight = 165.682327F;
            descricao.HeaderText = "Descrição";
            descricao.Name = "descricao";
            // 
            // quantidade
            // 
            quantidade.FillWeight = 56.3267632F;
            quantidade.HeaderText = "Quantidade";
            quantidade.Name = "quantidade";
            // 
            // BtFinalizar
            // 
            BtFinalizar.Image = Properties.Resources.verifica__2___1_;
            BtFinalizar.ImageAlign = ContentAlignment.MiddleRight;
            BtFinalizar.Location = new Point(26, 491);
            BtFinalizar.Name = "BtFinalizar";
            BtFinalizar.Size = new Size(75, 23);
            BtFinalizar.TabIndex = 2;
            BtFinalizar.Text = "Finalizar";
            BtFinalizar.TextAlign = ContentAlignment.MiddleLeft;
            BtFinalizar.UseVisualStyleBackColor = true;
            // 
            // BtOriginais
            // 
            BtOriginais.Image = Properties.Resources.lupa_de_pesquisa__1___1___1_;
            BtOriginais.ImageAlign = ContentAlignment.MiddleRight;
            BtOriginais.Location = new Point(129, 491);
            BtOriginais.Name = "BtOriginais";
            BtOriginais.Size = new Size(110, 23);
            BtOriginais.TabIndex = 3;
            BtOriginais.Text = "Itens originais";
            BtOriginais.TextAlign = ContentAlignment.MiddleLeft;
            BtOriginais.UseVisualStyleBackColor = true;
            // 
            // BtLimpar
            // 
            BtLimpar.Image = Properties.Resources.lixeira_de_reciclagem__1_;
            BtLimpar.ImageAlign = ContentAlignment.MiddleRight;
            BtLimpar.Location = new Point(271, 491);
            BtLimpar.Name = "BtLimpar";
            BtLimpar.Size = new Size(75, 23);
            BtLimpar.TabIndex = 4;
            BtLimpar.Text = "Limpar";
            BtLimpar.UseVisualStyleBackColor = true;
            // 
            // BtCancelar
            // 
            BtCancelar.Image = Properties.Resources.cancelar__1_;
            BtCancelar.ImageAlign = ContentAlignment.MiddleRight;
            BtCancelar.Location = new Point(383, 491);
            BtCancelar.Name = "BtCancelar";
            BtCancelar.Size = new Size(75, 23);
            BtCancelar.TabIndex = 5;
            BtCancelar.Text = "Cancelar";
            BtCancelar.TextAlign = ContentAlignment.MiddleLeft;
            BtCancelar.UseVisualStyleBackColor = true;
            // 
            // LancamentodeDevolucao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 524);
            Controls.Add(BtCancelar);
            Controls.Add(BtLimpar);
            Controls.Add(BtOriginais);
            Controls.Add(BtFinalizar);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "LancamentodeDevolucao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LancamentodeDevolucao";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button BtProcura;
        private TextBox TfProduto;
        private Label label1;
        private Label label2;
        private TextBox TfQuantidade;
        private Button BtConfirmar;
        private Label LbDescricao;
        private Label LbReferencia;
        private Label LbCodigo;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
        private Button BtFinalizar;
        private Button BtOriginais;
        private Button BtLimpar;
        private Button BtCancelar;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn referencia;
        private DataGridViewTextBoxColumn descricao;
        private DataGridViewTextBoxColumn quantidade;
    }
}