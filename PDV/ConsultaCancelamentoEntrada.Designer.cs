namespace PDV
{
    partial class ConsultaCancelamentoEntrada
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
            TfDocumento = new TextBox();
            label1 = new Label();
            label3 = new Label();
            TfData2 = new MaskedTextBox();
            TfData1 = new MaskedTextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            BtLimpar = new Button();
            BtProcurar = new Button();
            dataGridView1 = new DataGridView();
            Documento = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            Motivo = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // TfDocumento
            // 
            TfDocumento.Location = new Point(4, 41);
            TfDocumento.Name = "TfDocumento";
            TfDocumento.Size = new Size(100, 23);
            TfDocumento.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 23);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 1;
            label1.Text = "Documento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(211, 46);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 13;
            label3.Text = "a";
            // 
            // TfData2
            // 
            TfData2.Location = new Point(235, 41);
            TfData2.Mask = "00/00/0000";
            TfData2.Name = "TfData2";
            TfData2.Size = new Size(70, 23);
            TfData2.TabIndex = 12;
            TfData2.ValidatingType = typeof(DateTime);
            // 
            // TfData1
            // 
            TfData1.Location = new Point(129, 41);
            TfData1.Mask = "00/00/0000";
            TfData1.Name = "TfData1";
            TfData1.Size = new Size(70, 23);
            TfData1.TabIndex = 11;
            TfData1.ValidatingType = typeof(DateTime);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 23);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 10;
            label2.Text = "Data";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtLimpar);
            groupBox1.Controls.Add(BtProcurar);
            groupBox1.Controls.Add(TfData2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TfDocumento);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TfData1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(8, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(791, 116);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // BtLimpar
            // 
            BtLimpar.Image = Properties.Resources.lixeira_de_reciclagem__1_;
            BtLimpar.ImageAlign = ContentAlignment.MiddleLeft;
            BtLimpar.Location = new Point(670, 61);
            BtLimpar.Name = "BtLimpar";
            BtLimpar.Size = new Size(75, 23);
            BtLimpar.TabIndex = 15;
            BtLimpar.Text = "   Limpar";
            BtLimpar.UseVisualStyleBackColor = true;
            BtLimpar.Click += BtLimpar_Click;
            // 
            // BtProcurar
            // 
            BtProcurar.Image = Properties.Resources.lupa_de_pesquisa__1___1___1_;
            BtProcurar.ImageAlign = ContentAlignment.MiddleLeft;
            BtProcurar.Location = new Point(670, 23);
            BtProcurar.Name = "BtProcurar";
            BtProcurar.Size = new Size(75, 23);
            BtProcurar.TabIndex = 14;
            BtProcurar.Text = "Procurar";
            BtProcurar.TextAlign = ContentAlignment.MiddleRight;
            BtProcurar.UseVisualStyleBackColor = true;
            BtProcurar.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Menu;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Documento, Data, Motivo });
            dataGridView1.Location = new Point(12, 134);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(787, 360);
            dataGridView1.TabIndex = 15;
            // 
            // Documento
            // 
            Documento.DataPropertyName = "documento";
            Documento.FillWeight = 72.1381F;
            Documento.HeaderText = "Documento";
            Documento.Name = "Documento";
            // 
            // Data
            // 
            Data.DataPropertyName = "dataCancelamento";
            Data.FillWeight = 60.9137F;
            Data.HeaderText = "Data do cancelamento";
            Data.Name = "Data";
            // 
            // Motivo
            // 
            Motivo.DataPropertyName = "motivo";
            Motivo.FillWeight = 166.948166F;
            Motivo.HeaderText = "Motivo";
            Motivo.Name = "Motivo";
            // 
            // ConsultaCancelamentoEntrada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 506);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "ConsultaCancelamentoEntrada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConsultaCancelamentoEntrada";
            Load += ConsultaCancelamentoEntrada_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox TfDocumento;
        private Label label1;
        private Label label3;
        private MaskedTextBox TfData2;
        private MaskedTextBox TfData1;
        private Label label2;
        private GroupBox groupBox1;
        private Button BtLimpar;
        private Button BtProcurar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Motivo;
    }
}