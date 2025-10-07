namespace PDV
{
    partial class JanelaCancelamentodeSaidas
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            LbValor = new Label();
            LbData = new Label();
            LbDocumento = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            TfDocumento = new TextBox();
            TfMotivo = new TextBox();
            BtProcurar = new Button();
            BtLimpar = new Button();
            BtConfirmar = new Button();
            BtCancelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 10);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Documento";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LbValor);
            groupBox1.Controls.Add(LbData);
            groupBox1.Controls.Add(LbDocumento);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(7, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(255, 100);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // LbValor
            // 
            LbValor.AutoSize = true;
            LbValor.Location = new Point(80, 65);
            LbValor.Name = "LbValor";
            LbValor.Size = new Size(25, 15);
            LbValor.TabIndex = 5;
            LbValor.Text = "000";
            // 
            // LbData
            // 
            LbData.AutoSize = true;
            LbData.Location = new Point(80, 41);
            LbData.Name = "LbData";
            LbData.Size = new Size(65, 15);
            LbData.TabIndex = 4;
            LbData.Text = "07/10/2025";
            // 
            // LbDocumento
            // 
            LbDocumento.AutoSize = true;
            LbDocumento.Location = new Point(80, 15);
            LbDocumento.Name = "LbDocumento";
            LbDocumento.Size = new Size(25, 15);
            LbDocumento.TabIndex = 3;
            LbDocumento.Text = "000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1, 65);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 2;
            label4.Text = "Valor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1, 41);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 1;
            label3.Text = "Data:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 15);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 0;
            label2.Text = "Documento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 189);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 6;
            label5.Text = "Motivo";
            // 
            // TfDocumento
            // 
            TfDocumento.Location = new Point(7, 28);
            TfDocumento.Name = "TfDocumento";
            TfDocumento.Size = new Size(100, 23);
            TfDocumento.TabIndex = 10;
            // 
            // TfMotivo
            // 
            TfMotivo.Location = new Point(8, 207);
            TfMotivo.Multiline = true;
            TfMotivo.Name = "TfMotivo";
            TfMotivo.Size = new Size(254, 126);
            TfMotivo.TabIndex = 11;
            // 
            // BtProcurar
            // 
            BtProcurar.Image = Properties.Resources.lupa_de_pesquisa__1___1___1_;
            BtProcurar.ImageAlign = ContentAlignment.MiddleLeft;
            BtProcurar.Location = new Point(177, 12);
            BtProcurar.Name = "BtProcurar";
            BtProcurar.Size = new Size(75, 23);
            BtProcurar.TabIndex = 12;
            BtProcurar.Text = "Procurar";
            BtProcurar.TextAlign = ContentAlignment.MiddleRight;
            BtProcurar.UseVisualStyleBackColor = true;
            // 
            // BtLimpar
            // 
            BtLimpar.Image = Properties.Resources.lixeira_de_reciclagem__1_;
            BtLimpar.ImageAlign = ContentAlignment.MiddleLeft;
            BtLimpar.Location = new Point(177, 50);
            BtLimpar.Name = "BtLimpar";
            BtLimpar.Size = new Size(75, 23);
            BtLimpar.TabIndex = 13;
            BtLimpar.Text = "Limpar";
            BtLimpar.UseVisualStyleBackColor = true;
            // 
            // BtConfirmar
            // 
            BtConfirmar.Image = Properties.Resources.verifica__2___1_;
            BtConfirmar.ImageAlign = ContentAlignment.MiddleLeft;
            BtConfirmar.Location = new Point(32, 349);
            BtConfirmar.Name = "BtConfirmar";
            BtConfirmar.Size = new Size(80, 23);
            BtConfirmar.TabIndex = 14;
            BtConfirmar.Text = "Confirmar";
            BtConfirmar.TextAlign = ContentAlignment.MiddleRight;
            BtConfirmar.UseVisualStyleBackColor = true;
            // 
            // BtCancelar
            // 
            BtCancelar.Image = Properties.Resources.cancelar__1_;
            BtCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            BtCancelar.Location = new Point(143, 349);
            BtCancelar.Name = "BtCancelar";
            BtCancelar.Size = new Size(75, 23);
            BtCancelar.TabIndex = 15;
            BtCancelar.Text = "Cancelar";
            BtCancelar.TextAlign = ContentAlignment.MiddleRight;
            BtCancelar.UseVisualStyleBackColor = true;
            // 
            // JanelaCancelamentodeSaidas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 384);
            Controls.Add(BtCancelar);
            Controls.Add(BtConfirmar);
            Controls.Add(BtLimpar);
            Controls.Add(BtProcurar);
            Controls.Add(TfMotivo);
            Controls.Add(TfDocumento);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "JanelaCancelamentodeSaidas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JanelaCancelamentodeSaidas";
            Load += JanelaCancelamentodeSaidas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private Label label2;
        private Label LbValor;
        private Label LbData;
        private Label LbDocumento;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private Label label5;
        private Button Bt;
        private TextBox TfDocumento;
        private TextBox TfMotivo;
        private Button BtProcurar;
        private Button BtLimpar;
        private Button BtConfirmar;
        private Button BtCancelar;
    }
}