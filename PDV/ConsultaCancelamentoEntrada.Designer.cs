namespace PDV
{
    partial class ConsultaCancelamentoEntrada
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
            TfDocumento = new TextBox();
            label1 = new Label();
            label3 = new Label();
            TfData2 = new MaskedTextBox();
            TfData1 = new MaskedTextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // TfDocumento
            // 
            TfDocumento.Location = new Point(4, 41);
            TfDocumento.Name = "TfDocumento";
            TfDocumento.Size = new Size(100, 23);
            TfDocumento.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 23);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 1;
            label1.Text = "Documento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(258, 46);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 13;
            label3.Text = "a";
            // 
            // TfData2
            // 
            TfData2.Location = new Point(282, 41);
            TfData2.Mask = "00/00/0000";
            TfData2.Name = "TfData2";
            TfData2.Size = new Size(70, 23);
            TfData2.TabIndex = 12;
            TfData2.ValidatingType = typeof(DateTime);
            // 
            // TfData1
            // 
            TfData1.Location = new Point(176, 41);
            TfData1.Mask = "00/00/0000";
            TfData1.Name = "TfData1";
            TfData1.Size = new Size(70, 23);
            TfData1.TabIndex = 11;
            TfData1.ValidatingType = typeof(DateTime);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 23);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 10;
            label2.Text = "Data";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(TfData2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TfDocumento);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TfData1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(8, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(876, 145);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // button2
            // 
            button2.Image = Properties.Resources.lixeira_de_reciclagem__1_;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(708, 66);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 15;
            button2.Text = "   Limpar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.lupa_de_pesquisa__1___1___1_;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(708, 28);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "Procurar";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            // 
            // ConsultaCancelamentoEntrada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 506);
            Controls.Add(groupBox1);
            Name = "ConsultaCancelamentoEntrada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConsultaCancelamentoEntrada";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox TfDocumento;
        private Label label1;
        private Label label3;
        private MaskedTextBox TfData2;
        private MaskedTextBox TfData1;
        private Label label2;
        private GroupBox groupBox1;
        private Button button2;
        private Button button1;
    }
}