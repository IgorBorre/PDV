namespace PDV
{
    partial class JanelaConsultaSaidas
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
            btLimpar = new Button();
            btProcurar = new Button();
            TfData2 = new MaskedTextBox();
            label4 = new Label();
            TfData1 = new MaskedTextBox();
            label3 = new Label();
            TfCliente = new TextBox();
            TfIdCliente = new TextBox();
            label2 = new Label();
            TfDocumento = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            documento = new DataGridViewTextBoxColumn();
            cliente = new DataGridViewTextBoxColumn();
            data = new DataGridViewTextBoxColumn();
            valor = new DataGridViewTextBoxColumn();
            desconto = new DataGridViewTextBoxColumn();
            acrescimo = new DataGridViewTextBoxColumn();
            valortotal = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btLimpar);
            groupBox1.Controls.Add(btProcurar);
            groupBox1.Controls.Add(TfData2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TfData1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TfCliente);
            groupBox1.Controls.Add(TfIdCliente);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TfDocumento);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(2, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(845, 126);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // btLimpar
            // 
            btLimpar.Image = Properties.Resources.lixeira_de_reciclagem__1_;
            btLimpar.ImageAlign = ContentAlignment.MiddleLeft;
            btLimpar.Location = new Point(672, 69);
            btLimpar.Name = "btLimpar";
            btLimpar.Size = new Size(75, 23);
            btLimpar.TabIndex = 10;
            btLimpar.Text = "Limpar";
            btLimpar.UseVisualStyleBackColor = true;
            btLimpar.Click += btLimpar_Click;
            // 
            // btProcurar
            // 
            btProcurar.Image = Properties.Resources.lupa_de_pesquisa__1___1___1_;
            btProcurar.ImageAlign = ContentAlignment.MiddleLeft;
            btProcurar.Location = new Point(672, 31);
            btProcurar.Name = "btProcurar";
            btProcurar.Size = new Size(75, 23);
            btProcurar.TabIndex = 9;
            btProcurar.Text = "Procurar";
            btProcurar.TextAlign = ContentAlignment.MiddleRight;
            btProcurar.UseVisualStyleBackColor = true;
            btProcurar.Click += btProcurar_Click;
            // 
            // TfData2
            // 
            TfData2.Location = new Point(262, 35);
            TfData2.Mask = "00/00/0000";
            TfData2.Name = "TfData2";
            TfData2.Size = new Size(70, 23);
            TfData2.TabIndex = 8;
            TfData2.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(243, 38);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 7;
            label4.Text = "a";
            // 
            // TfData1
            // 
            TfData1.Location = new Point(167, 35);
            TfData1.Mask = "00/00/0000";
            TfData1.Name = "TfData1";
            TfData1.Size = new Size(70, 23);
            TfData1.TabIndex = 6;
            TfData1.ValidatingType = typeof(DateTime);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(176, 19);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 5;
            label3.Text = "Data";
            // 
            // TfCliente
            // 
            TfCliente.Location = new Point(56, 91);
            TfCliente.Name = "TfCliente";
            TfCliente.Size = new Size(239, 23);
            TfCliente.TabIndex = 4;
            // 
            // TfIdCliente
            // 
            TfIdCliente.Location = new Point(6, 91);
            TfIdCliente.Name = "TfIdCliente";
            TfIdCliente.Size = new Size(44, 23);
            TfIdCliente.TabIndex = 3;
            TfIdCliente.Leave += TfIdCliente_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 73);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 2;
            label2.Text = "Cliente";
            // 
            // TfDocumento
            // 
            TfDocumento.Location = new Point(6, 35);
            TfDocumento.Name = "TfDocumento";
            TfDocumento.Size = new Size(100, 23);
            TfDocumento.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 17);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Documento";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.MenuBar;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { documento, cliente, data, valor, desconto, acrescimo, valortotal });
            dataGridView1.Location = new Point(2, 153);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(845, 355);
            dataGridView1.TabIndex = 1;
            // 
            // documento
            // 
            documento.DataPropertyName = "documento";
            documento.FillWeight = 60.9137039F;
            documento.HeaderText = "Documento";
            documento.Name = "documento";
            documento.ReadOnly = true;
            // 
            // cliente
            // 
            cliente.DataPropertyName = "clienteNome";
            cliente.FillWeight = 107.817261F;
            cliente.HeaderText = "Cliente";
            cliente.Name = "cliente";
            cliente.ReadOnly = true;
            // 
            // data
            // 
            data.DataPropertyName = "dataSaida";
            data.FillWeight = 107.817261F;
            data.HeaderText = "Data";
            data.Name = "data";
            data.ReadOnly = true;
            // 
            // valor
            // 
            valor.DataPropertyName = "subtotal";
            valor.FillWeight = 107.817261F;
            valor.HeaderText = "Subtotal";
            valor.Name = "valor";
            valor.ReadOnly = true;
            // 
            // desconto
            // 
            desconto.DataPropertyName = "desconto";
            desconto.FillWeight = 107.817261F;
            desconto.HeaderText = "Desconto";
            desconto.Name = "desconto";
            desconto.ReadOnly = true;
            // 
            // acrescimo
            // 
            acrescimo.DataPropertyName = "acrescimo";
            acrescimo.FillWeight = 107.817261F;
            acrescimo.HeaderText = "Acréscimo";
            acrescimo.Name = "acrescimo";
            acrescimo.ReadOnly = true;
            // 
            // valortotal
            // 
            valortotal.DataPropertyName = "valortotal";
            valortotal.HeaderText = "Valor";
            valortotal.Name = "valortotal";
            valortotal.ReadOnly = true;
            // 
            // JanelaConsultaSaidas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 520);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "JanelaConsultaSaidas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JanelaConsultaSaidas";
            Load += JanelaConsultaSaidas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox TfCliente;
        private TextBox TfIdCliente;
        private Label label2;
        private TextBox TfDocumento;
        private Label label1;
        private MaskedTextBox TfData2;
        private Label label4;
        private MaskedTextBox TfData1;
        private Label label3;
        private DataGridView dataGridView1;
        private Button btLimpar;
        private Button btProcurar;
        private DataGridViewTextBoxColumn documento;
        private DataGridViewTextBoxColumn cliente;
        private DataGridViewTextBoxColumn data;
        private DataGridViewTextBoxColumn valor;
        private DataGridViewTextBoxColumn desconto;
        private DataGridViewTextBoxColumn acrescimo;
        private DataGridViewTextBoxColumn valortotal;
    }
}