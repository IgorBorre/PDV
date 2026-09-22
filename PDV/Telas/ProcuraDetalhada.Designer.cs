namespace PDV.Telas
{
    partial class ProcuraDetalhada
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
            BtProcurar = new Button();
            TfData2 = new MaskedTextBox();
            label2 = new Label();
            TfData1 = new MaskedTextBox();
            label111 = new Label();
            TfClienteNome = new TextBox();
            TfCliente = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            documento = new DataGridViewTextBoxColumn();
            clienteNome = new DataGridViewTextBoxColumn();
            dataSaida = new DataGridViewTextBoxColumn();
            valortotal = new DataGridViewTextBoxColumn();
            BtImportar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtProcurar);
            groupBox1.Controls.Add(TfData2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TfData1);
            groupBox1.Controls.Add(label111);
            groupBox1.Controls.Add(TfClienteNome);
            groupBox1.Controls.Add(TfCliente);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(1, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(797, 77);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // BtProcurar
            // 
            BtProcurar.Image = Properties.Resources.lupa_de_pesquisa__1___1___1_;
            BtProcurar.ImageAlign = ContentAlignment.MiddleRight;
            BtProcurar.Location = new Point(643, 36);
            BtProcurar.Name = "BtProcurar";
            BtProcurar.Size = new Size(75, 23);
            BtProcurar.TabIndex = 7;
            BtProcurar.Text = "Procurar";
            BtProcurar.TextAlign = ContentAlignment.MiddleLeft;
            BtProcurar.UseVisualStyleBackColor = true;
            BtProcurar.Click += BtProcurar_Click;
            // 
            // TfData2
            // 
            TfData2.Location = new Point(458, 37);
            TfData2.Mask = "00/00/0000";
            TfData2.Name = "TfData2";
            TfData2.Size = new Size(80, 23);
            TfData2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(439, 40);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 5;
            label2.Text = "a";
            // 
            // TfData1
            // 
            TfData1.Location = new Point(353, 37);
            TfData1.Mask = "00/00/0000";
            TfData1.Name = "TfData1";
            TfData1.Size = new Size(80, 23);
            TfData1.TabIndex = 4;
            // 
            // label111
            // 
            label111.AutoSize = true;
            label111.Location = new Point(353, 19);
            label111.Name = "label111";
            label111.Size = new Size(31, 15);
            label111.TabIndex = 3;
            label111.Text = "Data";
            // 
            // TfClienteNome
            // 
            TfClienteNome.Location = new Point(61, 37);
            TfClienteNome.Name = "TfClienteNome";
            TfClienteNome.Size = new Size(236, 23);
            TfClienteNome.TabIndex = 2;
            TfClienteNome.Leave += TfClienteNome_Leave;
            // 
            // TfCliente
            // 
            TfCliente.Location = new Point(11, 37);
            TfCliente.Name = "TfCliente";
            TfCliente.Size = new Size(44, 23);
            TfCliente.TabIndex = 1;
            TfCliente.Leave += TfCliente_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 19);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Cliente";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { documento, clienteNome, dataSaida, valortotal });
            dataGridView1.Location = new Point(12, 85);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(776, 405);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // documento
            // 
            documento.DataPropertyName = "documento";
            documento.FillWeight = 74.188324F;
            documento.HeaderText = "Documento";
            documento.Name = "documento";
            // 
            // clienteNome
            // 
            clienteNome.DataPropertyName = "clienteNome";
            clienteNome.FillWeight = 170.13855F;
            clienteNome.HeaderText = "Cliente";
            clienteNome.Name = "clienteNome";
            // 
            // dataSaida
            // 
            dataSaida.DataPropertyName = "dataSaida";
            dataSaida.FillWeight = 74.45487F;
            dataSaida.HeaderText = "Data";
            dataSaida.Name = "dataSaida";
            // 
            // valortotal
            // 
            valortotal.DataPropertyName = "valortotal";
            valortotal.FillWeight = 81.21828F;
            valortotal.HeaderText = "Valor";
            valortotal.Name = "valortotal";
            // 
            // BtImportar
            // 
            BtImportar.Enabled = false;
            BtImportar.Image = Properties.Resources.import__1_;
            BtImportar.ImageAlign = ContentAlignment.MiddleRight;
            BtImportar.Location = new Point(27, 496);
            BtImportar.Name = "BtImportar";
            BtImportar.Size = new Size(75, 23);
            BtImportar.TabIndex = 2;
            BtImportar.Text = "Importar";
            BtImportar.TextAlign = ContentAlignment.MiddleLeft;
            BtImportar.UseVisualStyleBackColor = true;
            BtImportar.Click += BtImportar_Click;
            // 
            // ProcuraDetalhada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 527);
            Controls.Add(BtImportar);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "ProcuraDetalhada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProcuraDetalhada";
            Load += ProcuraDetalhada_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox TfClienteNome;
        private TextBox TfCliente;
        private Label label1;
        private MaskedTextBox TfData2;
        private Label label2;
        private MaskedTextBox TfData1;
        private Label label111;
        private DataGridView dataGridView1;
        private Button BtProcurar;
        private Button BtImportar;
        private DataGridViewTextBoxColumn documento;
        private DataGridViewTextBoxColumn clienteNome;
        private DataGridViewTextBoxColumn dataSaida;
        private DataGridViewTextBoxColumn valortotal;
    }
}