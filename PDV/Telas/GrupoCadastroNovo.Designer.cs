namespace PDV
{
    partial class GrupoCadastroNovo
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
            label2 = new Label();
            TfCodigo = new TextBox();
            TfNome = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 27);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 27);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // TfCodigo
            // 
            TfCodigo.Enabled = false;
            TfCodigo.Location = new Point(7, 45);
            TfCodigo.Name = "TfCodigo";
            TfCodigo.Size = new Size(46, 23);
            TfCodigo.TabIndex = 2;
            // 
            // TfNome
            // 
            TfNome.Location = new Point(68, 45);
            TfNome.Name = "TfNome";
            TfNome.Size = new Size(320, 23);
            TfNome.TabIndex = 3;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.verifica__2___1_;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(7, 97);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.cancelar__1_;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(130, 97);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Cancelar";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // GrupoCadastroNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 130);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(TfNome);
            Controls.Add(TfCodigo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GrupoCadastroNovo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GrupoCadastroNovo";
            Load += GrupoCadastroNovo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TfNome;
        private Button button1;
        private Button button2;
        public TextBox TfCodigo;
    }
}