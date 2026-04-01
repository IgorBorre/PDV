namespace PDV
{
    partial class JanelaConsultaDevolucao
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
            label1 = new Label();
            TfDocumento = new TextBox();
            TfData1 = new MaskedTextBox();
            Data = new Label();
            label2 = new Label();
            TfData2 = new MaskedTextBox();
            label3 = new Label();
            TfIdCliente = new TextBox();
            TfCliente = new TextBox();
            BtProcura = new Button();
            BtLimpar = new Button();
            dataGridView1 = new DataGridView();
            documento = new DataGridViewTextBoxColumn();
            nomeCliente = new DataGridViewTextBoxColumn();
            dataDevolucao = new DataGridViewTextBoxColumn();
            doc_original = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtLimpar);
            groupBox1.Controls.Add(BtProcura);
            groupBox1.Controls.Add(TfCliente);
            groupBox1.Controls.Add(TfIdCliente);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TfData2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(Data);
            groupBox1.Controls.Add(TfData1);
            groupBox1.Controls.Add(TfDocumento);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(992, 129);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Documento";
            // 
            // TfDocumento
            // 
            TfDocumento.Location = new Point(6, 37);
            TfDocumento.Name = "TfDocumento";
            TfDocumento.Size = new Size(100, 23);
            TfDocumento.TabIndex = 1;
            // 
            // TfData1
            // 
            TfData1.Location = new Point(157, 37);
            TfData1.Mask = "00/00/0000";
            TfData1.Name = "TfData1";
            TfData1.Size = new Size(70, 23);
            TfData1.TabIndex = 7;
            TfData1.ValidatingType = typeof(DateTime);
            // 
            // Data
            // 
            Data.AutoSize = true;
            Data.Location = new Point(157, 19);
            Data.Name = "Data";
            Data.Size = new Size(31, 15);
            Data.TabIndex = 8;
            Data.Text = "Data";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(233, 40);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 9;
            label2.Text = "a";
            // 
            // TfData2
            // 
            TfData2.Location = new Point(252, 37);
            TfData2.Mask = "00/00/0000";
            TfData2.Name = "TfData2";
            TfData2.Size = new Size(70, 23);
            TfData2.TabIndex = 10;
            TfData2.ValidatingType = typeof(DateTime);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 79);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 11;
            label3.Text = "Cliente";
            // 
            // TfIdCliente
            // 
            TfIdCliente.Location = new Point(6, 97);
            TfIdCliente.Name = "TfIdCliente";
            TfIdCliente.Size = new Size(44, 23);
            TfIdCliente.TabIndex = 12;
            // 
            // TfCliente
            // 
            TfCliente.Location = new Point(56, 97);
            TfCliente.Name = "TfCliente";
            TfCliente.Size = new Size(265, 23);
            TfCliente.TabIndex = 13;
            // 
            // BtProcura
            // 
            BtProcura.Image = Properties.Resources.lupa_de_pesquisa__1___1___1_;
            BtProcura.ImageAlign = ContentAlignment.MiddleLeft;
            BtProcura.Location = new Point(838, 36);
            BtProcura.Name = "BtProcura";
            BtProcura.Size = new Size(75, 23);
            BtProcura.TabIndex = 14;
            BtProcura.Text = "Procurar";
            BtProcura.TextAlign = ContentAlignment.MiddleRight;
            BtProcura.UseVisualStyleBackColor = true;
            // 
            // BtLimpar
            // 
            BtLimpar.Image = Properties.Resources.lixeira_de_reciclagem__1_;
            BtLimpar.ImageAlign = ContentAlignment.MiddleLeft;
            BtLimpar.Location = new Point(838, 79);
            BtLimpar.Name = "BtLimpar";
            BtLimpar.Size = new Size(75, 23);
            BtLimpar.TabIndex = 15;
            BtLimpar.Text = "  Limpar";
            BtLimpar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { documento, nomeCliente, dataDevolucao, doc_original });
            dataGridView1.Location = new Point(12, 147);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(992, 500);
            dataGridView1.TabIndex = 1;
            // 
            // documento
            // 
            documento.FillWeight = 48.1980362F;
            documento.HeaderText = "Documento";
            documento.Name = "documento";
            documento.ReadOnly = true;
            // 
            // nomeCliente
            // 
            nomeCliente.FillWeight = 204.825439F;
            nomeCliente.HeaderText = "Cliente";
            nomeCliente.Name = "nomeCliente";
            nomeCliente.ReadOnly = true;
            // 
            // dataDevolucao
            // 
            dataDevolucao.FillWeight = 86.06286F;
            dataDevolucao.HeaderText = "Data";
            dataDevolucao.Name = "dataDevolucao";
            dataDevolucao.ReadOnly = true;
            // 
            // doc_original
            // 
            doc_original.FillWeight = 60.9137154F;
            doc_original.HeaderText = "Documento Original";
            doc_original.Name = "doc_original";
            doc_original.ReadOnly = true;
            // 
            // JanelaConsultaDevolucao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 659);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "JanelaConsultaDevolucao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JanelaConsultaDevolucao";
            Load += JanelaConsultaDevolucao_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox TfCliente;
        private TextBox TfIdCliente;
        private Label label3;
        private MaskedTextBox TfData2;
        private Label label2;
        private Label Data;
        private MaskedTextBox TfData1;
        private TextBox TfDocumento;
        private Label label1;
        private Button BtLimpar;
        private Button BtProcura;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn documento;
        private DataGridViewTextBoxColumn nomeCliente;
        private DataGridViewTextBoxColumn dataDevolucao;
        private DataGridViewTextBoxColumn doc_original;
    }
}