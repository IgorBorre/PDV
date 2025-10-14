namespace PDV
{
    partial class JanelaConsultaCancelamento
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
            Data = new Label();
            TfData1 = new MaskedTextBox();
            label2 = new Label();
            TfData2 = new MaskedTextBox();
            BtProcurar = new Button();
            BtLimpar = new Button();
            dataGridView1 = new DataGridView();
            Documento = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            Motivo = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtLimpar);
            groupBox1.Controls.Add(BtProcurar);
            groupBox1.Controls.Add(TfData2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TfData1);
            groupBox1.Controls.Add(Data);
            groupBox1.Controls.Add(TfDocumento);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(859, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 20);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Documento";
            // 
            // TfDocumento
            // 
            TfDocumento.Location = new Point(10, 41);
            TfDocumento.Name = "TfDocumento";
            TfDocumento.Size = new Size(100, 23);
            TfDocumento.TabIndex = 1;
            // 
            // Data
            // 
            Data.AutoSize = true;
            Data.Location = new Point(178, 20);
            Data.Name = "Data";
            Data.Size = new Size(31, 15);
            Data.TabIndex = 2;
            Data.Text = "Data";
            // 
            // TfData1
            // 
            TfData1.Location = new Point(178, 38);
            TfData1.Mask = "00/00/0000";
            TfData1.Name = "TfData1";
            TfData1.Size = new Size(70, 23);
            TfData1.TabIndex = 7;
            TfData1.ValidatingType = typeof(DateTime);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(254, 42);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 8;
            label2.Text = "a";
            // 
            // TfData2
            // 
            TfData2.Location = new Point(273, 38);
            TfData2.Mask = "00/00/0000";
            TfData2.Name = "TfData2";
            TfData2.Size = new Size(70, 23);
            TfData2.TabIndex = 9;
            TfData2.ValidatingType = typeof(DateTime);
            // 
            // BtProcurar
            // 
            BtProcurar.Image = Properties.Resources.lupa_de_pesquisa__1___1___1_;
            BtProcurar.ImageAlign = ContentAlignment.MiddleLeft;
            BtProcurar.Location = new Point(714, 22);
            BtProcurar.Name = "BtProcurar";
            BtProcurar.Size = new Size(75, 23);
            BtProcurar.TabIndex = 10;
            BtProcurar.Text = "Procurar";
            BtProcurar.TextAlign = ContentAlignment.MiddleRight;
            BtProcurar.UseVisualStyleBackColor = true;
            // 
            // BtLimpar
            // 
            BtLimpar.Image = Properties.Resources.lixeira_de_reciclagem__1_;
            BtLimpar.ImageAlign = ContentAlignment.MiddleLeft;
            BtLimpar.Location = new Point(714, 51);
            BtLimpar.Name = "BtLimpar";
            BtLimpar.Size = new Size(75, 23);
            BtLimpar.TabIndex = 11;
            BtLimpar.Text = "   Limpar";
            BtLimpar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Documento, date, Motivo });
            dataGridView1.Location = new Point(3, 136);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(859, 366);
            dataGridView1.TabIndex = 1;
            // 
            // Documento
            // 
            Documento.DataPropertyName = "documento";
            Documento.FillWeight = 61.182045F;
            Documento.HeaderText = "Documento";
            Documento.Name = "Documento";
            Documento.ReadOnly = true;
            // 
            // date
            // 
            date.DataPropertyName = "dataCancelamento";
            date.FillWeight = 68.527916F;
            date.HeaderText = "Data";
            date.Name = "date";
            date.ReadOnly = true;
            // 
            // Motivo
            // 
            Motivo.DataPropertyName = "motivo";
            Motivo.FillWeight = 170.290039F;
            Motivo.HeaderText = "Motivo";
            Motivo.Name = "Motivo";
            Motivo.ReadOnly = true;
            // 
            // JanelaConsultaCancelamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 505);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "JanelaConsultaCancelamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JanelaConsultaCancelamento";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private MaskedTextBox TfData2;
        private Label label2;
        private MaskedTextBox TfData1;
        private Label Data;
        private TextBox TfDocumento;
        private Label label1;
        private Button BtLimpar;
        private Button BtProcurar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn Motivo;
    }
}