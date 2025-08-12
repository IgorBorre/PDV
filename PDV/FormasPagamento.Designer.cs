namespace PDV
{
    partial class FormasPagamento
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
            btIncluir = new Button();
            RbInativas = new RadioButton();
            RbAtivas = new RadioButton();
            RbTodas = new RadioButton();
            dataGridView1 = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            descricao = new DataGridViewTextBoxColumn();
            ativa = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btIncluir);
            groupBox1.Controls.Add(RbInativas);
            groupBox1.Controls.Add(RbAtivas);
            groupBox1.Controls.Add(RbTodas);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 67);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // btIncluir
            // 
            btIncluir.Image = Properties.Resources.inserir__2___1_;
            btIncluir.ImageAlign = ContentAlignment.MiddleRight;
            btIncluir.Location = new Point(650, 23);
            btIncluir.Name = "btIncluir";
            btIncluir.Size = new Size(75, 23);
            btIncluir.TabIndex = 2;
            btIncluir.Text = "Incluir";
            btIncluir.UseVisualStyleBackColor = true;
            btIncluir.Click += btIncluir_Click;
            // 
            // RbInativas
            // 
            RbInativas.AutoSize = true;
            RbInativas.Location = new Point(135, 23);
            RbInativas.Name = "RbInativas";
            RbInativas.Size = new Size(65, 19);
            RbInativas.TabIndex = 1;
            RbInativas.TabStop = true;
            RbInativas.Text = "Inativas";
            RbInativas.UseVisualStyleBackColor = true;
            RbInativas.CheckedChanged += RbInativas_CheckedChanged;
            // 
            // RbAtivas
            // 
            RbAtivas.AutoSize = true;
            RbAtivas.Location = new Point(72, 23);
            RbAtivas.Name = "RbAtivas";
            RbAtivas.Size = new Size(57, 19);
            RbAtivas.TabIndex = 1;
            RbAtivas.TabStop = true;
            RbAtivas.Text = "Ativas";
            RbAtivas.UseVisualStyleBackColor = true;
            RbAtivas.CheckedChanged += RbAtivas_CheckedChanged;
            // 
            // RbTodas
            // 
            RbTodas.AutoSize = true;
            RbTodas.Location = new Point(10, 23);
            RbTodas.Name = "RbTodas";
            RbTodas.Size = new Size(56, 19);
            RbTodas.TabIndex = 0;
            RbTodas.TabStop = true;
            RbTodas.Text = "Todas";
            RbTodas.UseVisualStyleBackColor = true;
            RbTodas.CheckedChanged += RbTodas_CheckedChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { codigo, descricao, ativa });
            dataGridView1.Location = new Point(15, 95);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(773, 627);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.Sorted += dataGridView1_Sorted;
            // 
            // codigo
            // 
            codigo.DataPropertyName = "id";
            codigo.FillWeight = 37.0654144F;
            codigo.HeaderText = "Código";
            codigo.Name = "codigo";
            codigo.ReadOnly = true;
            // 
            // descricao
            // 
            descricao.DataPropertyName = "descricao";
            descricao.FillWeight = 224.8635F;
            descricao.HeaderText = "Descrição";
            descricao.Name = "descricao";
            descricao.ReadOnly = true;
            // 
            // ativa
            // 
            ativa.DataPropertyName = "ativa";
            ativa.FillWeight = 38.0710678F;
            ativa.HeaderText = "Ativa?";
            ativa.Name = "ativa";
            ativa.ReadOnly = true;
            // 
            // FormasPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 734);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "FormasPagamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormasPagamento";
            Load += FormasPagamento_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton RbAtivas;
        private RadioButton RbTodas;
        private RadioButton RbInativas;
        private Button btIncluir;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn descricao;
        private DataGridViewTextBoxColumn ativa;
    }
}