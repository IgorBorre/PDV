namespace PDV
{
    partial class JanelaCancelamentodeEntradas
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
            TfDocumento = new TextBox();
            BtProcurar = new Button();
            BtLimpar = new Button();
            groupBox1 = new GroupBox();
            lbFornecedor = new Label();
            lbData = new Label();
            lbDocumento = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            TfMotivo = new TextBox();
            label5 = new Label();
            BtConfirmar = new Button();
            BtCancelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 10);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Documento";
            // 
            // TfDocumento
            // 
            TfDocumento.Location = new Point(6, 28);
            TfDocumento.Name = "TfDocumento";
            TfDocumento.Size = new Size(79, 23);
            TfDocumento.TabIndex = 1;
            // 
            // BtProcurar
            // 
            BtProcurar.Image = Properties.Resources.lupa_de_pesquisa__1___1___1_;
            BtProcurar.ImageAlign = ContentAlignment.MiddleLeft;
            BtProcurar.Location = new Point(167, 12);
            BtProcurar.Name = "BtProcurar";
            BtProcurar.Size = new Size(75, 23);
            BtProcurar.TabIndex = 2;
            BtProcurar.Text = "Procurar";
            BtProcurar.TextAlign = ContentAlignment.MiddleRight;
            BtProcurar.UseVisualStyleBackColor = true;
            BtProcurar.Click += BtProcurar_Click;
            // 
            // BtLimpar
            // 
            BtLimpar.Image = Properties.Resources.lixeira_de_reciclagem__1_;
            BtLimpar.ImageAlign = ContentAlignment.MiddleLeft;
            BtLimpar.Location = new Point(167, 41);
            BtLimpar.Name = "BtLimpar";
            BtLimpar.Size = new Size(75, 23);
            BtLimpar.TabIndex = 3;
            BtLimpar.Text = "   Limpar";
            BtLimpar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbFornecedor);
            groupBox1.Controls.Add(lbData);
            groupBox1.Controls.Add(lbDocumento);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(6, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(265, 106);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // lbFornecedor
            // 
            lbFornecedor.AutoSize = true;
            lbFornecedor.Location = new Point(89, 75);
            lbFornecedor.Name = "lbFornecedor";
            lbFornecedor.Size = new Size(0, 15);
            lbFornecedor.TabIndex = 5;
            // 
            // lbData
            // 
            lbData.AutoSize = true;
            lbData.Location = new Point(88, 50);
            lbData.Name = "lbData";
            lbData.Size = new Size(0, 15);
            lbData.TabIndex = 4;
            // 
            // lbDocumento
            // 
            lbDocumento.AutoSize = true;
            lbDocumento.Location = new Point(88, 24);
            lbDocumento.Name = "lbDocumento";
            lbDocumento.Size = new Size(0, 15);
            lbDocumento.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 74);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 2;
            label4.Text = "Fornecedor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 50);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 1;
            label3.Text = "Data:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 24);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 0;
            label2.Text = "Documento:";
            // 
            // TfMotivo
            // 
            TfMotivo.Location = new Point(4, 244);
            TfMotivo.Multiline = true;
            TfMotivo.Name = "TfMotivo";
            TfMotivo.Size = new Size(267, 146);
            TfMotivo.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 226);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 6;
            label5.Text = "Motivo";
            // 
            // BtConfirmar
            // 
            BtConfirmar.Image = Properties.Resources.verifica__2___1_;
            BtConfirmar.ImageAlign = ContentAlignment.MiddleLeft;
            BtConfirmar.Location = new Point(11, 420);
            BtConfirmar.Name = "BtConfirmar";
            BtConfirmar.Size = new Size(85, 23);
            BtConfirmar.TabIndex = 7;
            BtConfirmar.Text = "Confirmar";
            BtConfirmar.TextAlign = ContentAlignment.MiddleRight;
            BtConfirmar.UseVisualStyleBackColor = true;
            BtConfirmar.Click += BtConfirmar_Click;
            // 
            // BtCancelar
            // 
            BtCancelar.Image = Properties.Resources.cancelar__1_;
            BtCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            BtCancelar.Location = new Point(134, 420);
            BtCancelar.Name = "BtCancelar";
            BtCancelar.Size = new Size(75, 23);
            BtCancelar.TabIndex = 8;
            BtCancelar.Text = "Cancelar";
            BtCancelar.TextAlign = ContentAlignment.MiddleRight;
            BtCancelar.UseVisualStyleBackColor = true;
            // 
            // JanelaCancelamentodeEntradas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 450);
            Controls.Add(BtCancelar);
            Controls.Add(BtConfirmar);
            Controls.Add(label5);
            Controls.Add(TfMotivo);
            Controls.Add(groupBox1);
            Controls.Add(BtLimpar);
            Controls.Add(BtProcurar);
            Controls.Add(TfDocumento);
            Controls.Add(label1);
            Name = "JanelaCancelamentodeEntradas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JanelaCancelamentodeEntradas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TfDocumento;
        private Button BtProcurar;
        private Button BtLimpar;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox TfMotivo;
        private Label label5;
        private Button BtConfirmar;
        private Button BtCancelar;
        private Label lbFornecedor;
        private Label lbData;
        private Label lbDocumento;
    }
}