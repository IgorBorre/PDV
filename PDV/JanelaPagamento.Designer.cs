namespace PDV
{
    partial class JanelaPagamento
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
            BtConfirmar = new Button();
            BtCancelar = new Button();
            BtLimpar = new Button();
            BtFinalizar = new Button();
            listBox1 = new ListBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            label1 = new Label();
            LbPago = new Label();
            label2 = new Label();
            LbTotal = new Label();
            label3 = new Label();
            LbFalta = new Label();
            label4 = new Label();
            LbTroco = new Label();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { codigo, descricao });
            dataGridView1.Location = new Point(1, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(342, 452);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // codigo
            // 
            codigo.DataPropertyName = "id";
            codigo.FillWeight = 35.5329933F;
            codigo.HeaderText = "Código";
            codigo.Name = "codigo";
            codigo.ReadOnly = true;
            // 
            // descricao
            // 
            descricao.DataPropertyName = "descricao";
            descricao.FillWeight = 164.46701F;
            descricao.HeaderText = "Descrição";
            descricao.Name = "descricao";
            descricao.ReadOnly = true;
            // 
            // BtConfirmar
            // 
            BtConfirmar.Image = Properties.Resources.verifica__2___1_;
            BtConfirmar.ImageAlign = ContentAlignment.MiddleRight;
            BtConfirmar.Location = new Point(12, 542);
            BtConfirmar.Name = "BtConfirmar";
            BtConfirmar.Size = new Size(86, 23);
            BtConfirmar.TabIndex = 1;
            BtConfirmar.Text = "Confirmar";
            BtConfirmar.TextAlign = ContentAlignment.MiddleLeft;
            BtConfirmar.UseVisualStyleBackColor = true;
            // 
            // BtCancelar
            // 
            BtCancelar.Image = Properties.Resources.cancelar__1_;
            BtCancelar.ImageAlign = ContentAlignment.MiddleRight;
            BtCancelar.Location = new Point(125, 542);
            BtCancelar.Name = "BtCancelar";
            BtCancelar.Size = new Size(86, 23);
            BtCancelar.TabIndex = 2;
            BtCancelar.Text = "Cancelar";
            BtCancelar.TextAlign = ContentAlignment.MiddleLeft;
            BtCancelar.UseVisualStyleBackColor = true;
            BtCancelar.Click += BtCancelar_Click;
            // 
            // BtLimpar
            // 
            BtLimpar.Image = Properties.Resources.lixeira_de_reciclagem__1_;
            BtLimpar.ImageAlign = ContentAlignment.MiddleRight;
            BtLimpar.Location = new Point(243, 542);
            BtLimpar.Name = "BtLimpar";
            BtLimpar.Size = new Size(86, 23);
            BtLimpar.TabIndex = 3;
            BtLimpar.Text = "Limpar";
            BtLimpar.TextAlign = ContentAlignment.MiddleLeft;
            BtLimpar.UseVisualStyleBackColor = true;
            BtLimpar.Click += BtLimpar_Click;
            // 
            // BtFinalizar
            // 
            BtFinalizar.Image = Properties.Resources.payment_method__1_1;
            BtFinalizar.ImageAlign = ContentAlignment.MiddleRight;
            BtFinalizar.Location = new Point(371, 542);
            BtFinalizar.Name = "BtFinalizar";
            BtFinalizar.Size = new Size(86, 23);
            BtFinalizar.TabIndex = 4;
            BtFinalizar.Text = "Finalizar";
            BtFinalizar.TextAlign = ContentAlignment.MiddleLeft;
            BtFinalizar.UseVisualStyleBackColor = true;
            BtFinalizar.Click += BtFinalizar_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(349, 25);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(390, 364);
            listBox1.TabIndex = 5;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Location = new Point(349, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(390, 28);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Forma de pagamento";
            columnHeader1.Width = 206;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Parcelas";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Valor";
            columnHeader3.Width = 120;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(483, 407);
            label1.Name = "label1";
            label1.Size = new Size(78, 17);
            label1.TabIndex = 7;
            label1.Text = "Total pago:";
            // 
            // LbPago
            // 
            LbPago.AutoSize = true;
            LbPago.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbPago.Location = new Point(567, 407);
            LbPago.Name = "LbPago";
            LbPago.Size = new Size(33, 17);
            LbPago.TabIndex = 8;
            LbPago.Text = "0,00";
            LbPago.Click += label2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(518, 435);
            label2.Name = "label2";
            label2.Size = new Size(43, 17);
            label2.TabIndex = 9;
            label2.Text = "Total:";
            // 
            // LbTotal
            // 
            LbTotal.AutoSize = true;
            LbTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbTotal.Location = new Point(567, 435);
            LbTotal.Name = "LbTotal";
            LbTotal.Size = new Size(33, 17);
            LbTotal.TabIndex = 10;
            LbTotal.Text = "0,00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(479, 461);
            label3.Name = "label3";
            label3.Size = new Size(82, 17);
            label3.TabIndex = 11;
            label3.Text = "Falta pagar:";
            // 
            // LbFalta
            // 
            LbFalta.AutoSize = true;
            LbFalta.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbFalta.Location = new Point(567, 461);
            LbFalta.Name = "LbFalta";
            LbFalta.Size = new Size(33, 17);
            LbFalta.TabIndex = 12;
            LbFalta.Text = "0,00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(515, 487);
            label4.Name = "label4";
            label4.Size = new Size(46, 17);
            label4.TabIndex = 13;
            label4.Text = "Troco:";
            // 
            // LbTroco
            // 
            LbTroco.AutoSize = true;
            LbTroco.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbTroco.Location = new Point(567, 487);
            LbTroco.Name = "LbTroco";
            LbTroco.Size = new Size(33, 17);
            LbTroco.TabIndex = 14;
            LbTroco.Text = "0,00";
            // 
            // JanelaPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 576);
            Controls.Add(LbTroco);
            Controls.Add(label4);
            Controls.Add(LbFalta);
            Controls.Add(label3);
            Controls.Add(LbTotal);
            Controls.Add(label2);
            Controls.Add(LbPago);
            Controls.Add(label1);
            Controls.Add(listView1);
            Controls.Add(listBox1);
            Controls.Add(BtFinalizar);
            Controls.Add(BtLimpar);
            Controls.Add(BtCancelar);
            Controls.Add(BtConfirmar);
            Controls.Add(dataGridView1);
            Name = "JanelaPagamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JanelaPagamento";
            Load += JanelaPagamento_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button BtConfirmar;
        private Button BtCancelar;
        private Button BtLimpar;
        private ListBox listBox1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        public Label LbPago;
        public Label LbTotal;
        public Label LbFalta;
        public Label LbTroco;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn descricao;
        public Button BtFinalizar;
    }
}