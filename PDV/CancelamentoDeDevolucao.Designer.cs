namespace PDV
{
    partial class CancelamentoDeDevolucao
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
            BtLimpar = new Button();
            BtProcura = new Button();
            TfDocumento = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            LbTotal = new Label();
            LbData = new Label();
            LbCliente = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            BtExecutar = new Button();
            BtCancelar = new Button();
            LbDocumento = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtLimpar);
            groupBox1.Controls.Add(BtProcura);
            groupBox1.Controls.Add(TfDocumento);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(331, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // BtLimpar
            // 
            BtLimpar.Image = Properties.Resources.lixeira_de_reciclagem__1_;
            BtLimpar.ImageAlign = ContentAlignment.MiddleLeft;
            BtLimpar.Location = new Point(177, 51);
            BtLimpar.Name = "BtLimpar";
            BtLimpar.Size = new Size(75, 23);
            BtLimpar.TabIndex = 3;
            BtLimpar.Text = "  Limpar";
            BtLimpar.UseVisualStyleBackColor = true;
            // 
            // BtProcura
            // 
            BtProcura.Image = Properties.Resources.lupa_de_pesquisa__1___1___1_;
            BtProcura.ImageAlign = ContentAlignment.MiddleLeft;
            BtProcura.Location = new Point(177, 22);
            BtProcura.Name = "BtProcura";
            BtProcura.Size = new Size(75, 23);
            BtProcura.TabIndex = 2;
            BtProcura.Text = "Procurar";
            BtProcura.TextAlign = ContentAlignment.MiddleRight;
            BtProcura.UseVisualStyleBackColor = true;
            BtProcura.Click += BtProcura_Click;
            // 
            // TfDocumento
            // 
            TfDocumento.Location = new Point(6, 37);
            TfDocumento.Name = "TfDocumento";
            TfDocumento.Size = new Size(100, 23);
            TfDocumento.TabIndex = 1;
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
            // groupBox2
            // 
            groupBox2.Controls.Add(LbTotal);
            groupBox2.Controls.Add(LbData);
            groupBox2.Controls.Add(LbCliente);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(12, 118);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(331, 111);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informações da devolução";
            // 
            // LbTotal
            // 
            LbTotal.AutoSize = true;
            LbTotal.Location = new Point(59, 68);
            LbTotal.Name = "LbTotal";
            LbTotal.Size = new Size(28, 15);
            LbTotal.TabIndex = 5;
            LbTotal.Text = "0,00";
            // 
            // LbData
            // 
            LbData.AutoSize = true;
            LbData.Location = new Point(59, 43);
            LbData.Name = "LbData";
            LbData.Size = new Size(0, 15);
            LbData.TabIndex = 4;
            // 
            // LbCliente
            // 
            LbCliente.AutoSize = true;
            LbCliente.Location = new Point(59, 19);
            LbCliente.Name = "LbCliente";
            LbCliente.Size = new Size(0, 15);
            LbCliente.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 68);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 2;
            label4.Text = "Total:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 43);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 1;
            label3.Text = "Data:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 0;
            label2.Text = "Cliente:";
            // 
            // BtExecutar
            // 
            BtExecutar.Image = Properties.Resources.verifica__2___1_;
            BtExecutar.ImageAlign = ContentAlignment.MiddleLeft;
            BtExecutar.Location = new Point(24, 253);
            BtExecutar.Name = "BtExecutar";
            BtExecutar.Size = new Size(75, 23);
            BtExecutar.TabIndex = 2;
            BtExecutar.Text = "Executar";
            BtExecutar.TextAlign = ContentAlignment.MiddleRight;
            BtExecutar.UseVisualStyleBackColor = true;
            BtExecutar.Click += BtExecutar_Click;
            // 
            // BtCancelar
            // 
            BtCancelar.Image = Properties.Resources.cancelar__1_;
            BtCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            BtCancelar.Location = new Point(167, 253);
            BtCancelar.Name = "BtCancelar";
            BtCancelar.Size = new Size(75, 23);
            BtCancelar.TabIndex = 3;
            BtCancelar.Text = "Cancelar";
            BtCancelar.TextAlign = ContentAlignment.MiddleRight;
            BtCancelar.UseVisualStyleBackColor = true;
            // 
            // LbDocumento
            // 
            LbDocumento.AutoSize = true;
            LbDocumento.Location = new Point(248, 257);
            LbDocumento.Name = "LbDocumento";
            LbDocumento.Size = new Size(0, 15);
            LbDocumento.TabIndex = 4;
            LbDocumento.Visible = false;
            // 
            // CancelamentoDeDevolucao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 293);
            Controls.Add(LbDocumento);
            Controls.Add(BtCancelar);
            Controls.Add(BtExecutar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "CancelamentoDeDevolucao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cancelar Devolução";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button BtLimpar;
        private Button BtProcura;
        private TextBox TfDocumento;
        private Label label1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private Label LbTotal;
        private Label LbData;
        private Label LbCliente;
        private Label label4;
        private Button BtExecutar;
        private Button BtCancelar;
        public Label LbDocumento;
    }
}