﻿namespace PDV
{
    partial class JanelaVenda
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
            TfId = new TextBox();
            Produto = new Label();
            TfQtd = new TextBox();
            label1 = new Label();
            TfPreco = new TextBox();
            label2 = new Label();
            listBox1 = new ListBox();
            groupBox1 = new GroupBox();
            LbPreco = new Label();
            LbEstoque = new Label();
            LbDescricao = new Label();
            LbReferencia = new Label();
            LbCodigo = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label8 = new Label();
            label9 = new Label();
            F3 = new Button();
            label10 = new Label();
            label11 = new Label();
            F4 = new Button();
            label12 = new Label();
            F5 = new Button();
            label13 = new Label();
            F6 = new Button();
            LbQuantidade = new Label();
            LbTotal = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // TfId
            // 
            TfId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TfId.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TfId.Location = new Point(12, 48);
            TfId.Name = "TfId";
            TfId.Size = new Size(1134, 25);
            TfId.TabIndex = 0;
            TfId.Leave += textBox1_Leave;
            // 
            // Produto
            // 
            Produto.AutoSize = true;
            Produto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Produto.Location = new Point(12, 28);
            Produto.Name = "Produto";
            Produto.Size = new Size(58, 17);
            Produto.TabIndex = 1;
            Produto.Text = "Produto";
            // 
            // TfQtd
            // 
            TfQtd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TfQtd.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TfQtd.Location = new Point(1152, 48);
            TfQtd.Name = "TfQtd";
            TfQtd.Size = new Size(100, 25);
            TfQtd.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1152, 28);
            label1.Name = "label1";
            label1.Size = new Size(80, 17);
            label1.TabIndex = 3;
            label1.Text = "Quantidade";
            // 
            // TfPreco
            // 
            TfPreco.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TfPreco.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TfPreco.Location = new Point(1258, 48);
            TfPreco.Name = "TfPreco";
            TfPreco.Size = new Size(100, 25);
            TfPreco.TabIndex = 4;
            TfPreco.KeyDown += TfPreco_KeyDown;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1258, 28);
            label2.Name = "label2";
            label2.Size = new Size(42, 17);
            label2.TabIndex = 5;
            label2.Text = "Preço";
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 79);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(381, 514);
            listBox1.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(LbPreco);
            groupBox1.Controls.Add(LbEstoque);
            groupBox1.Controls.Add(LbDescricao);
            groupBox1.Controls.Add(LbReferencia);
            groupBox1.Controls.Add(LbCodigo);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(399, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(959, 454);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalhes do produto";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // LbPreco
            // 
            LbPreco.AutoSize = true;
            LbPreco.Location = new Point(53, 163);
            LbPreco.Name = "LbPreco";
            LbPreco.Size = new Size(0, 15);
            LbPreco.TabIndex = 9;
            // 
            // LbEstoque
            // 
            LbEstoque.AutoSize = true;
            LbEstoque.Location = new Point(62, 131);
            LbEstoque.Name = "LbEstoque";
            LbEstoque.Size = new Size(0, 15);
            LbEstoque.TabIndex = 8;
            // 
            // LbDescricao
            // 
            LbDescricao.AutoSize = true;
            LbDescricao.Location = new Point(74, 99);
            LbDescricao.Name = "LbDescricao";
            LbDescricao.Size = new Size(0, 15);
            LbDescricao.TabIndex = 7;
            // 
            // LbReferencia
            // 
            LbReferencia.AutoSize = true;
            LbReferencia.Location = new Point(74, 68);
            LbReferencia.Name = "LbReferencia";
            LbReferencia.Size = new Size(0, 15);
            LbReferencia.TabIndex = 6;
            // 
            // LbCodigo
            // 
            LbCodigo.AutoSize = true;
            LbCodigo.Location = new Point(62, 33);
            LbCodigo.Name = "LbCodigo";
            LbCodigo.Size = new Size(0, 15);
            LbCodigo.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 163);
            label7.Name = "label7";
            label7.Size = new Size(37, 15);
            label7.TabIndex = 4;
            label7.Text = "Preço";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 131);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 3;
            label6.Text = "Estoque";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 99);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 2;
            label5.Text = "Descrição";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 67);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 1;
            label4.Text = "Referência";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 33);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 0;
            label3.Text = "Código";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 612);
            label8.Name = "label8";
            label8.Size = new Size(127, 30);
            label8.TabIndex = 8;
            label8.Text = "Quantidade:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(77, 654);
            label9.Name = "label9";
            label9.Size = new Size(62, 30);
            label9.TabIndex = 9;
            label9.Text = "Total:";
            // 
            // F3
            // 
            F3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            F3.Location = new Point(57, 699);
            F3.Name = "F3";
            F3.Size = new Size(29, 23);
            F3.TabIndex = 10;
            F3.Text = "F3";
            F3.UseVisualStyleBackColor = true;
            F3.KeyDown += button1_KeyDown;
            F3.KeyPress += button1_KeyPress;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(92, 701);
            label10.Name = "label10";
            label10.Size = new Size(47, 17);
            label10.TabIndex = 5;
            label10.Text = "Cliente";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(245, 701);
            label11.Name = "label11";
            label11.Size = new Size(63, 17);
            label11.TabIndex = 11;
            label11.Text = "Desconto";
            // 
            // F4
            // 
            F4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            F4.Location = new Point(210, 699);
            F4.Name = "F4";
            F4.Size = new Size(29, 23);
            F4.TabIndex = 12;
            F4.Text = "F4";
            F4.UseVisualStyleBackColor = true;
            F4.KeyDown += F4_KeyDown;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(412, 699);
            label12.Name = "label12";
            label12.Size = new Size(55, 17);
            label12.TabIndex = 13;
            label12.Text = "Finalizar";
            label12.Click += label12_Click;
            // 
            // F5
            // 
            F5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            F5.Location = new Point(377, 697);
            F5.Name = "F5";
            F5.Size = new Size(29, 23);
            F5.TabIndex = 14;
            F5.Text = "F5";
            F5.UseVisualStyleBackColor = true;
            F5.Click += F5_Click;
            F5.KeyDown += F5_KeyDown;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(588, 699);
            label13.Name = "label13";
            label13.Size = new Size(65, 17);
            label13.TabIndex = 15;
            label13.Text = "Vendedor";
            // 
            // F6
            // 
            F6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            F6.Location = new Point(553, 697);
            F6.Name = "F6";
            F6.Size = new Size(29, 23);
            F6.TabIndex = 16;
            F6.Text = "F6";
            F6.UseVisualStyleBackColor = true;
            F6.KeyDown += F6_KeyDown;
            // 
            // LbQuantidade
            // 
            LbQuantidade.AutoSize = true;
            LbQuantidade.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbQuantidade.Location = new Point(145, 612);
            LbQuantidade.Name = "LbQuantidade";
            LbQuantidade.Size = new Size(0, 30);
            LbQuantidade.TabIndex = 17;
            // 
            // LbTotal
            // 
            LbTotal.AutoSize = true;
            LbTotal.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbTotal.Location = new Point(145, 654);
            LbTotal.Name = "LbTotal";
            LbTotal.Size = new Size(0, 30);
            LbTotal.TabIndex = 18;
            // 
            // JanelaVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1370, 749);
            Controls.Add(LbTotal);
            Controls.Add(LbQuantidade);
            Controls.Add(label13);
            Controls.Add(F6);
            Controls.Add(label12);
            Controls.Add(F5);
            Controls.Add(label11);
            Controls.Add(F4);
            Controls.Add(label10);
            Controls.Add(F3);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(TfPreco);
            Controls.Add(label1);
            Controls.Add(TfQtd);
            Controls.Add(Produto);
            Controls.Add(TfId);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "JanelaVenda";
            Text = "JanelaVenda";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            KeyDown += JanelaVenda_KeyDown;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TfId;
        private Label Produto;
        private TextBox TfQtd;
        private Label label1;
        private TextBox TfPreco;
        private Label label2;
        private ListBox listBox1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label label8;
        private Label label9;
        private Button F3;
        private Label label10;
        private Label label11;
        private Button F4;
        private Label label12;
        private Button F5;
        private Label label13;
        private Button F6;
        private Label LbPreco;
        private Label LbEstoque;
        private Label LbDescricao;
        private Label LbReferencia;
        private Label LbCodigo;
        private Label LbQuantidade;
        private Label LbTotal;
    }
}