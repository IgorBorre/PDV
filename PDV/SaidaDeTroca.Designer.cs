namespace PDV
{
    partial class SaidaDeTroca
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
            BtProcurar = new Button();
            label1 = new Label();
            TfDocumento = new TextBox();
            groupBox2 = new GroupBox();
            LbTotal = new Label();
            label4 = new Label();
            LbData = new Label();
            label3 = new Label();
            LbCliente = new Label();
            label2 = new Label();
            BtConfirmar = new Button();
            BtCancelar = new Button();
            LbDocumento = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtLimpar);
            groupBox1.Controls.Add(BtProcurar);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TfDocumento);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(428, 81);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // BtLimpar
            // 
            BtLimpar.Image = Properties.Resources.lixeira_de_reciclagem__1_;
            BtLimpar.ImageAlign = ContentAlignment.MiddleRight;
            BtLimpar.Location = new Point(323, 48);
            BtLimpar.Name = "BtLimpar";
            BtLimpar.Size = new Size(75, 23);
            BtLimpar.TabIndex = 3;
            BtLimpar.Text = "Limpar";
            BtLimpar.TextAlign = ContentAlignment.MiddleLeft;
            BtLimpar.UseVisualStyleBackColor = true;
            BtLimpar.Click += BtLimpar_Click;
            // 
            // BtProcurar
            // 
            BtProcurar.Image = Properties.Resources.lupa_de_pesquisa__1___1___1_;
            BtProcurar.ImageAlign = ContentAlignment.MiddleRight;
            BtProcurar.Location = new Point(323, 19);
            BtProcurar.Name = "BtProcurar";
            BtProcurar.Size = new Size(75, 23);
            BtProcurar.TabIndex = 2;
            BtProcurar.Text = "Procurar";
            BtProcurar.TextAlign = ContentAlignment.MiddleLeft;
            BtProcurar.UseVisualStyleBackColor = true;
            BtProcurar.Click += BtProcurar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 1;
            label1.Text = "Documento";
            // 
            // TfDocumento
            // 
            TfDocumento.Location = new Point(6, 37);
            TfDocumento.Name = "TfDocumento";
            TfDocumento.Size = new Size(112, 23);
            TfDocumento.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(LbTotal);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(LbData);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(LbCliente);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(12, 120);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(255, 111);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informações";
            // 
            // LbTotal
            // 
            LbTotal.AutoSize = true;
            LbTotal.Location = new Point(59, 69);
            LbTotal.Name = "LbTotal";
            LbTotal.Size = new Size(28, 15);
            LbTotal.TabIndex = 5;
            LbTotal.Text = "0,00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 69);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 4;
            label4.Text = "Total:";
            // 
            // LbData
            // 
            LbData.AutoSize = true;
            LbData.Location = new Point(59, 44);
            LbData.Name = "LbData";
            LbData.Size = new Size(0, 15);
            LbData.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 44);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 2;
            label3.Text = "Data:";
            // 
            // LbCliente
            // 
            LbCliente.AutoSize = true;
            LbCliente.Location = new Point(59, 19);
            LbCliente.Name = "LbCliente";
            LbCliente.Size = new Size(0, 15);
            LbCliente.TabIndex = 1;
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
            // BtConfirmar
            // 
            BtConfirmar.Image = Properties.Resources.verifica__2___1_;
            BtConfirmar.ImageAlign = ContentAlignment.MiddleRight;
            BtConfirmar.Location = new Point(14, 247);
            BtConfirmar.Name = "BtConfirmar";
            BtConfirmar.Size = new Size(83, 23);
            BtConfirmar.TabIndex = 2;
            BtConfirmar.Text = "Confirmar";
            BtConfirmar.TextAlign = ContentAlignment.MiddleLeft;
            BtConfirmar.UseVisualStyleBackColor = true;
            BtConfirmar.Click += BtConfirmar_Click;
            // 
            // BtCancelar
            // 
            BtCancelar.Image = Properties.Resources.cancelar__1_;
            BtCancelar.ImageAlign = ContentAlignment.MiddleRight;
            BtCancelar.Location = new Point(138, 247);
            BtCancelar.Name = "BtCancelar";
            BtCancelar.Size = new Size(75, 23);
            BtCancelar.TabIndex = 3;
            BtCancelar.Text = "Cancelar";
            BtCancelar.TextAlign = ContentAlignment.MiddleLeft;
            BtCancelar.UseVisualStyleBackColor = true;
            // 
            // LbDocumento
            // 
            LbDocumento.AutoSize = true;
            LbDocumento.Location = new Point(335, 120);
            LbDocumento.Name = "LbDocumento";
            LbDocumento.Size = new Size(0, 15);
            LbDocumento.TabIndex = 4;
            LbDocumento.Visible = false;
            // 
            // SaidaDeTroca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 295);
            Controls.Add(LbDocumento);
            Controls.Add(BtCancelar);
            Controls.Add(BtConfirmar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "SaidaDeTroca";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SaidaDeTroca";
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
        private Button BtProcurar;
        private Label label1;
        private TextBox TfDocumento;
        private GroupBox groupBox2;
        private Label label2;
        private Label LbTotal;
        private Label label4;
        private Label LbData;
        private Label label3;
        public Label LbCliente;
        private Button BtConfirmar;
        private Button BtCancelar;
        public Label LbDocumento;
    }
}