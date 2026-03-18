namespace PDV
{
    partial class ItensOriginais
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
            dataGridView1 = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            descricao = new DataGridViewTextBoxColumn();
            referencia = new DataGridViewTextBoxColumn();
            quantidade = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Menu;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { codigo, descricao, referencia, quantidade });
            dataGridView1.Location = new Point(3, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(912, 413);
            dataGridView1.TabIndex = 0;
            dataGridView1.Sorted += dataGridView1_Sorted;
            // 
            // codigo
            // 
            codigo.DataPropertyName = "codigo";
            codigo.FillWeight = 40.45066F;
            codigo.HeaderText = "Código";
            codigo.Name = "codigo";
            codigo.ReadOnly = true;
            // 
            // descricao
            // 
            descricao.DataPropertyName = "descricao";
            descricao.FillWeight = 149.400024F;
            descricao.HeaderText = "Descrição";
            descricao.Name = "descricao";
            descricao.ReadOnly = true;
            // 
            // referencia
            // 
            referencia.DataPropertyName = "referencia";
            referencia.FillWeight = 116.652122F;
            referencia.HeaderText = "Referência";
            referencia.Name = "referencia";
            referencia.ReadOnly = true;
            // 
            // quantidade
            // 
            quantidade.DataPropertyName = "quantidade";
            quantidade.FillWeight = 101.522842F;
            quantidade.HeaderText = "Quantidade";
            quantidade.Name = "quantidade";
            quantidade.ReadOnly = true;
            // 
            // ItensOriginais
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 415);
            Controls.Add(dataGridView1);
            Name = "ItensOriginais";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ItensOriginais";
            Load += ItensOriginais_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        public DataGridView dataGridView1;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn descricao;
        private DataGridViewTextBoxColumn referencia;
        private DataGridViewTextBoxColumn quantidade;
    }
}