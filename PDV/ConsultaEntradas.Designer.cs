namespace PDV
{
    partial class ConsultaEntradas
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
            BtLimpar = new Button();
            BtProcurar = new Button();
            TfFornecedor = new TextBox();
            TfIdFornecedor = new TextBox();
            label4 = new Label();
            label3 = new Label();
            TfData2 = new MaskedTextBox();
            TfData1 = new MaskedTextBox();
            label2 = new Label();
            TfDocumento = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Documento = new DataGridViewTextBoxColumn();
            Fornecedor = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtLimpar);
            groupBox1.Controls.Add(BtProcurar);
            groupBox1.Controls.Add(TfFornecedor);
            groupBox1.Controls.Add(TfIdFornecedor);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TfData2);
            groupBox1.Controls.Add(TfData1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TfDocumento);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(848, 137);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // BtLimpar
            // 
            BtLimpar.Image = Properties.Resources.lixeira_de_reciclagem__1_;
            BtLimpar.ImageAlign = ContentAlignment.MiddleLeft;
            BtLimpar.Location = new Point(689, 65);
            BtLimpar.Name = "BtLimpar";
            BtLimpar.Size = new Size(75, 23);
            BtLimpar.TabIndex = 14;
            BtLimpar.Text = "Limpar";
            BtLimpar.TextAlign = ContentAlignment.MiddleRight;
            BtLimpar.UseVisualStyleBackColor = true;
            BtLimpar.Click += BtLimpar_Click;
            // 
            // BtProcurar
            // 
            BtProcurar.Image = Properties.Resources.lupa_de_pesquisa__1___1___1_;
            BtProcurar.ImageAlign = ContentAlignment.MiddleLeft;
            BtProcurar.Location = new Point(689, 36);
            BtProcurar.Name = "BtProcurar";
            BtProcurar.Size = new Size(75, 23);
            BtProcurar.TabIndex = 13;
            BtProcurar.Text = "Procurar";
            BtProcurar.TextAlign = ContentAlignment.MiddleRight;
            BtProcurar.UseVisualStyleBackColor = true;
            BtProcurar.Click += BtProcurar_Click;
            // 
            // TfFornecedor
            // 
            TfFornecedor.Location = new Point(49, 94);
            TfFornecedor.Name = "TfFornecedor";
            TfFornecedor.Size = new Size(234, 23);
            TfFornecedor.TabIndex = 12;
            TfFornecedor.Enter += TfFornecedor_Enter;
            TfFornecedor.Leave += TfFornecedor_Leave;
            // 
            // TfIdFornecedor
            // 
            TfIdFornecedor.Location = new Point(6, 94);
            TfIdFornecedor.Name = "TfIdFornecedor";
            TfIdFornecedor.Size = new Size(37, 23);
            TfIdFornecedor.TabIndex = 11;
            TfIdFornecedor.Leave += TfIdFornecedor_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 76);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 10;
            label4.Text = "Fornecedor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(244, 44);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 9;
            label3.Text = "a";
            // 
            // TfData2
            // 
            TfData2.Location = new Point(268, 39);
            TfData2.Mask = "00/00/0000";
            TfData2.Name = "TfData2";
            TfData2.Size = new Size(70, 23);
            TfData2.TabIndex = 8;
            TfData2.ValidatingType = typeof(DateTime);
            // 
            // TfData1
            // 
            TfData1.Location = new Point(162, 39);
            TfData1.Mask = "00/00/0000";
            TfData1.Name = "TfData1";
            TfData1.Size = new Size(70, 23);
            TfData1.TabIndex = 7;
            TfData1.ValidatingType = typeof(DateTime);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(176, 21);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "Data";
            // 
            // TfDocumento
            // 
            TfDocumento.Location = new Point(6, 39);
            TfDocumento.Name = "TfDocumento";
            TfDocumento.Size = new Size(115, 23);
            TfDocumento.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 21);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Documento";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Documento, Fornecedor, Data });
            dataGridView1.Location = new Point(3, 155);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(848, 300);
            dataGridView1.TabIndex = 1;
            // 
            // Documento
            // 
            Documento.DataPropertyName = "documento";
            Documento.FillWeight = 60.9137039F;
            Documento.HeaderText = "Documento";
            Documento.Name = "Documento";
            Documento.ReadOnly = true;
            // 
            // Fornecedor
            // 
            Fornecedor.DataPropertyName = "nomefornecedor";
            Fornecedor.FillWeight = 152.744537F;
            Fornecedor.HeaderText = "Fornecedor";
            Fornecedor.Name = "Fornecedor";
            Fornecedor.ReadOnly = true;
            // 
            // Data
            // 
            Data.DataPropertyName = "dataentrada";
            Data.FillWeight = 86.34177F;
            Data.HeaderText = "Data";
            Data.Name = "Data";
            Data.ReadOnly = true;
            // 
            // ConsultaEntradas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 467);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "ConsultaEntradas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConsultaEntradas";
            Load += ConsultaEntradas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private TextBox TfDocumento;
        private Label label1;
        private Label label3;
        private MaskedTextBox TfData2;
        private MaskedTextBox TfData1;
        private TextBox TfFornecedor;
        private TextBox TfIdFornecedor;
        private Label label4;
        private Button BtProcurar;
        private Button BtLimpar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn Fornecedor;
        private DataGridViewTextBoxColumn Data;
    }
}