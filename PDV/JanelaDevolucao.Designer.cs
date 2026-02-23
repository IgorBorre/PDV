namespace PDV
{
    partial class JanelaDevolucao
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
            groupBox1 = new GroupBox();
            LbTotal = new Label();
            label6 = new Label();
            LbDesc = new Label();
            label5 = new Label();
            LbSubtotal = new Label();
            label4 = new Label();
            LbData = new Label();
            label3 = new Label();
            LbCliente = new Label();
            label2 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            BtConfirmar = new Button();
            BtCancelar = new Button();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 14);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Documento";
            // 
            // TfDocumento
            // 
            TfDocumento.Location = new Point(12, 32);
            TfDocumento.Name = "TfDocumento";
            TfDocumento.Size = new Size(100, 23);
            TfDocumento.TabIndex = 1;
            // 
            // BtProcurar
            // 
            BtProcurar.Image = Properties.Resources.lupa_de_pesquisa__1___1___1_;
            BtProcurar.ImageAlign = ContentAlignment.MiddleRight;
            BtProcurar.Location = new Point(202, 31);
            BtProcurar.Name = "BtProcurar";
            BtProcurar.Size = new Size(75, 23);
            BtProcurar.TabIndex = 2;
            BtProcurar.Text = "Procurar";
            BtProcurar.TextAlign = ContentAlignment.MiddleLeft;
            BtProcurar.UseVisualStyleBackColor = true;
            BtProcurar.Click += BtProcurar_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(LbTotal);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(LbDesc);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(LbSubtotal);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(LbData);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(LbCliente);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(8, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(269, 176);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // LbTotal
            // 
            LbTotal.AutoSize = true;
            LbTotal.Location = new Point(78, 133);
            LbTotal.Name = "LbTotal";
            LbTotal.Size = new Size(28, 15);
            LbTotal.TabIndex = 9;
            LbTotal.Text = "0,00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 133);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 8;
            label6.Text = "Total:";
            // 
            // LbDesc
            // 
            LbDesc.AutoSize = true;
            LbDesc.Location = new Point(78, 106);
            LbDesc.Name = "LbDesc";
            LbDesc.Size = new Size(28, 15);
            LbDesc.TabIndex = 7;
            LbDesc.Text = "0,00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 106);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 6;
            label5.Text = "Desc/Acr:";
            // 
            // LbSubtotal
            // 
            LbSubtotal.AutoSize = true;
            LbSubtotal.Location = new Point(78, 74);
            LbSubtotal.Name = "LbSubtotal";
            LbSubtotal.Size = new Size(28, 15);
            LbSubtotal.TabIndex = 5;
            LbSubtotal.Text = "0,00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 74);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 4;
            label4.Text = "Subtotal:";
            // 
            // LbData
            // 
            LbData.AutoSize = true;
            LbData.Location = new Point(78, 46);
            LbData.Name = "LbData";
            LbData.Size = new Size(0, 15);
            LbData.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 46);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 2;
            label3.Text = "Data:";
            // 
            // LbCliente
            // 
            LbCliente.AutoSize = true;
            LbCliente.Location = new Point(78, 16);
            LbCliente.Name = "LbCliente";
            LbCliente.Size = new Size(0, 15);
            LbCliente.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 16);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 0;
            label2.Text = "Cliente:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 31);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(54, 19);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Troca";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 56);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(119, 19);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "Devolução parcial";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(6, 81);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(108, 19);
            radioButton3.TabIndex = 6;
            radioButton3.TabStop = true;
            radioButton3.Text = "Devolução total";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // BtConfirmar
            // 
            BtConfirmar.Image = Properties.Resources.verifica__2___1_;
            BtConfirmar.ImageAlign = ContentAlignment.MiddleRight;
            BtConfirmar.Location = new Point(8, 408);
            BtConfirmar.Name = "BtConfirmar";
            BtConfirmar.Size = new Size(84, 23);
            BtConfirmar.TabIndex = 7;
            BtConfirmar.Text = "Confirmar";
            BtConfirmar.TextAlign = ContentAlignment.MiddleLeft;
            BtConfirmar.UseVisualStyleBackColor = true;
            // 
            // BtCancelar
            // 
            BtCancelar.Image = Properties.Resources.cancelar__1_;
            BtCancelar.ImageAlign = ContentAlignment.MiddleRight;
            BtCancelar.Location = new Point(114, 408);
            BtCancelar.Name = "BtCancelar";
            BtCancelar.Size = new Size(75, 23);
            BtCancelar.TabIndex = 8;
            BtCancelar.Text = "Cancelar";
            BtCancelar.TextAlign = ContentAlignment.MiddleLeft;
            BtCancelar.UseVisualStyleBackColor = true;
            BtCancelar.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Location = new Point(8, 280);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 113);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo de devolução";
            // 
            // JanelaDevolucao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 450);
            Controls.Add(groupBox2);
            Controls.Add(BtCancelar);
            Controls.Add(BtConfirmar);
            Controls.Add(groupBox1);
            Controls.Add(BtProcurar);
            Controls.Add(TfDocumento);
            Controls.Add(label1);
            Name = "JanelaDevolucao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JanelaDevolucao";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TfDocumento;
        private Button BtProcurar;
        private GroupBox groupBox1;
        private Label LbCliente;
        private Label label2;
        private Label LbSubtotal;
        private Label label4;
        private Label LbData;
        private Label label3;
        private Label LbDesc;
        private Label label5;
        private Label LbTotal;
        private Label label6;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Button BtConfirmar;
        private Button BtCancelar;
        private GroupBox groupBox2;
    }
}