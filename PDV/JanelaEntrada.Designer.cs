namespace PDV
{
    partial class JanelaEntrada
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
            btCancelar = new Button();
            btOk = new Button();
            label3 = new Label();
            tfQuantidade = new TextBox();
            label2 = new Label();
            tfProduto = new TextBox();
            tfIdProduto = new TextBox();
            label1 = new Label();
            tfFornecedor = new TextBox();
            tfIdFornecedor = new TextBox();
            btConfirmar = new Button();
            btLimpar = new Button();
            btCancelarTudo = new Button();
            dataGridView1 = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            descricao = new DataGridViewTextBoxColumn();
            quantidade = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btCancelar);
            groupBox1.Controls.Add(btOk);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tfQuantidade);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tfProduto);
            groupBox1.Controls.Add(tfIdProduto);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tfFornecedor);
            groupBox1.Controls.Add(tfIdFornecedor);
            groupBox1.Location = new Point(6, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(897, 169);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados";
            // 
            // btCancelar
            // 
            btCancelar.Image = Properties.Resources.cancelar__1_;
            btCancelar.ImageAlign = ContentAlignment.MiddleRight;
            btCancelar.Location = new Point(805, 98);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(75, 23);
            btCancelar.TabIndex = 8;
            btCancelar.Text = "Cancelar         ";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // btOk
            // 
            btOk.Image = Properties.Resources.verifica__2___1_;
            btOk.ImageAlign = ContentAlignment.MiddleRight;
            btOk.Location = new Point(731, 98);
            btOk.Name = "btOk";
            btOk.Size = new Size(57, 23);
            btOk.TabIndex = 7;
            btOk.Text = "Ok";
            btOk.UseVisualStyleBackColor = true;
            btOk.Click += btOk_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(597, 80);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 6;
            label3.Text = "Quantidade";
            // 
            // tfQuantidade
            // 
            tfQuantidade.Location = new Point(597, 98);
            tfQuantidade.Name = "tfQuantidade";
            tfQuantidade.Size = new Size(111, 23);
            tfQuantidade.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 80);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 5;
            label2.Text = "Produto";
            // 
            // tfProduto
            // 
            tfProduto.Location = new Point(48, 98);
            tfProduto.Name = "tfProduto";
            tfProduto.Size = new Size(513, 23);
            tfProduto.TabIndex = 4;
            // 
            // tfIdProduto
            // 
            tfIdProduto.Location = new Point(9, 98);
            tfIdProduto.Name = "tfIdProduto";
            tfIdProduto.Size = new Size(33, 23);
            tfIdProduto.TabIndex = 3;
            tfIdProduto.Leave += tfIdProduto_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 23);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 2;
            label1.Text = "Fornecedor";
            // 
            // tfFornecedor
            // 
            tfFornecedor.Location = new Point(48, 41);
            tfFornecedor.Name = "tfFornecedor";
            tfFornecedor.Size = new Size(343, 23);
            tfFornecedor.TabIndex = 1;
            tfFornecedor.Leave += tfFornecedor_Leave;
            // 
            // tfIdFornecedor
            // 
            tfIdFornecedor.Location = new Point(9, 41);
            tfIdFornecedor.Name = "tfIdFornecedor";
            tfIdFornecedor.Size = new Size(33, 23);
            tfIdFornecedor.TabIndex = 0;
            tfIdFornecedor.Leave += tfIdFornecedor_Leave;
            // 
            // btConfirmar
            // 
            btConfirmar.Image = Properties.Resources.verifica__2___1_;
            btConfirmar.ImageAlign = ContentAlignment.MiddleRight;
            btConfirmar.Location = new Point(12, 556);
            btConfirmar.Name = "btConfirmar";
            btConfirmar.Size = new Size(84, 23);
            btConfirmar.TabIndex = 8;
            btConfirmar.Text = "Confirmar";
            btConfirmar.TextAlign = ContentAlignment.MiddleLeft;
            btConfirmar.UseVisualStyleBackColor = true;
            btConfirmar.Click += btConfirmar_Click;
            // 
            // btLimpar
            // 
            btLimpar.Image = Properties.Resources.lixeira_de_reciclagem__1_;
            btLimpar.ImageAlign = ContentAlignment.MiddleRight;
            btLimpar.Location = new Point(119, 556);
            btLimpar.Name = "btLimpar";
            btLimpar.Size = new Size(77, 23);
            btLimpar.TabIndex = 9;
            btLimpar.Text = "Limpar";
            btLimpar.UseVisualStyleBackColor = true;
            btLimpar.Click += btLimpar_Click;
            // 
            // btCancelarTudo
            // 
            btCancelarTudo.Image = Properties.Resources.cancelar__1_;
            btCancelarTudo.ImageAlign = ContentAlignment.MiddleRight;
            btCancelarTudo.Location = new Point(214, 556);
            btCancelarTudo.Name = "btCancelarTudo";
            btCancelarTudo.Size = new Size(75, 23);
            btCancelarTudo.TabIndex = 10;
            btCancelarTudo.Text = "Cancelar";
            btCancelarTudo.TextAlign = ContentAlignment.MiddleLeft;
            btCancelarTudo.UseVisualStyleBackColor = true;
            btCancelarTudo.Click += btCancelarTudo_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.MenuBar;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { codigo, descricao, quantidade });
            dataGridView1.Enabled = false;
            dataGridView1.Location = new Point(15, 191);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(871, 359);
            dataGridView1.TabIndex = 11;
            dataGridView1.DataBindingComplete += dataGridView1_DataBindingComplete;
            dataGridView1.RowsAdded += dataGridView1_RowsAdded;
            dataGridView1.Sorted += dataGridView1_Sorted;
            // 
            // codigo
            // 
            codigo.FillWeight = 23.9733429F;
            codigo.HeaderText = "Código";
            codigo.Name = "codigo";
            codigo.ReadOnly = true;
            // 
            // descricao
            // 
            descricao.FillWeight = 245.569839F;
            descricao.HeaderText = "Descrição";
            descricao.Name = "descricao";
            descricao.ReadOnly = true;
            // 
            // quantidade
            // 
            quantidade.FillWeight = 30.4568558F;
            quantidade.HeaderText = "Quantidade";
            quantidade.Name = "quantidade";
            quantidade.ReadOnly = true;
            // 
            // JanelaEntrada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 591);
            Controls.Add(dataGridView1);
            Controls.Add(btCancelarTudo);
            Controls.Add(btLimpar);
            Controls.Add(btConfirmar);
            Controls.Add(groupBox1);
            Name = "JanelaEntrada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JanelaEntrada";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btCancelar;
        private Button btOk;
        private Label label3;
        private TextBox tfQuantidade;
        private Label label2;
        private TextBox tfProduto;
        private TextBox tfIdProduto;
        private Label label1;
        private TextBox tfFornecedor;
        private TextBox tfIdFornecedor;
        private Button btConfirmar;
        private Button btLimpar;
        private Button btCancelarTudo;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn descricao;
        private DataGridViewTextBoxColumn quantidade;
    }
}