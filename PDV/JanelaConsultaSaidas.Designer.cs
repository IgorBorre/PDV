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
            label1 = new Label();
            TfDocumento = new TextBox();
            label2 = new Label();
            TfIdCliente = new TextBox();
            TfCliente = new TextBox();
            label3 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label4 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            dataGridView1 = new DataGridView();
            documento = new DataGridViewTextBoxColumn();
            cliente = new DataGridViewTextBoxColumn();
            data = new DataGridViewTextBoxColumn();
            valor = new DataGridViewTextBoxColumn();
            desconto = new DataGridViewTextBoxColumn();
            acrescimo = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(maskedTextBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(maskedTextBox1);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 17);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Documento";
            // 
            // TfDocumento
            // 
            TfDocumento.Location = new Point(6, 35);
            TfDocumento.Name = "TfDocumento";
            TfDocumento.Size = new Size(100, 23);
            TfDocumento.TabIndex = 1;
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
            // TfIdCliente
            // 
            TfIdCliente.Location = new Point(6, 91);
            TfIdCliente.Name = "TfIdCliente";
            TfIdCliente.Size = new Size(44, 23);
            TfIdCliente.TabIndex = 3;
            // 
            // TfCliente
            // 
            TfCliente.Location = new Point(56, 91);
            TfCliente.Name = "TfCliente";
            TfCliente.Size = new Size(239, 23);
            TfCliente.TabIndex = 4;
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
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(176, 35);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(61, 23);
            maskedTextBox1.TabIndex = 6;
            maskedTextBox1.ValidatingType = typeof(DateTime);
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
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(262, 35);
            maskedTextBox2.Mask = "00/00/0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(61, 23);
            maskedTextBox2.TabIndex = 8;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.MenuBar;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { documento, cliente, data, valor, desconto, acrescimo });
            dataGridView1.Location = new Point(2, 153);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(845, 355);
            dataGridView1.TabIndex = 1;
            // 
            // documento
            // 
            documento.FillWeight = 60.9137039F;
            documento.HeaderText = "Documento";
            documento.Name = "documento";
            // 
            // cliente
            // 
            cliente.FillWeight = 107.817261F;
            cliente.HeaderText = "Cliente";
            cliente.Name = "cliente";
            // 
            // data
            // 
            data.FillWeight = 107.817261F;
            data.HeaderText = "Data";
            data.Name = "data";
            // 
            // valor
            // 
            valor.FillWeight = 107.817261F;
            valor.HeaderText = "Valor";
            valor.Name = "valor";
            // 
            // desconto
            // 
            desconto.FillWeight = 107.817261F;
            desconto.HeaderText = "Desconto";
            desconto.Name = "desconto";
            // 
            // acrescimo
            // 
            acrescimo.FillWeight = 107.817261F;
            acrescimo.HeaderText = "Acréscimo";
            acrescimo.Name = "acrescimo";
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
        private MaskedTextBox maskedTextBox2;
        private Label label4;
        private MaskedTextBox maskedTextBox1;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn documento;
        private DataGridViewTextBoxColumn cliente;
        private DataGridViewTextBoxColumn data;
        private DataGridViewTextBoxColumn valor;
        private DataGridViewTextBoxColumn desconto;
        private DataGridViewTextBoxColumn acrescimo;
    }
}