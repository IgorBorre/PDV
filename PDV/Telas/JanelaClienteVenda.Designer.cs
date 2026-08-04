namespace PDV
{
    partial class JanelaClienteVenda
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
            tfCodigo = new TextBox();
            tfNome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btOk = new Button();
            btCancelar = new Button();
            SuspendLayout();
            // 
            // tfCodigo
            // 
            tfCodigo.Location = new Point(8, 34);
            tfCodigo.Name = "tfCodigo";
            tfCodigo.Size = new Size(51, 23);
            tfCodigo.TabIndex = 0;
            tfCodigo.Leave += tfCodigo_Leave;
            // 
            // tfNome
            // 
            tfNome.Location = new Point(78, 34);
            tfNome.Name = "tfNome";
            tfNome.Size = new Size(387, 23);
            tfNome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 13);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 2;
            label1.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 13);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Nome";
            // 
            // btOk
            // 
            btOk.Image = Properties.Resources.verifica__2___1_;
            btOk.ImageAlign = ContentAlignment.MiddleLeft;
            btOk.Location = new Point(483, 17);
            btOk.Name = "btOk";
            btOk.Size = new Size(75, 23);
            btOk.TabIndex = 4;
            btOk.Text = "Ok";
            btOk.UseVisualStyleBackColor = true;
            btOk.Click += btOk_Click;
            // 
            // btCancelar
            // 
            btCancelar.Image = Properties.Resources.cancelar__1_;
            btCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btCancelar.Location = new Point(483, 47);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(75, 23);
            btCancelar.TabIndex = 5;
            btCancelar.Text = "Cancelar";
            btCancelar.TextAlign = ContentAlignment.MiddleRight;
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // JanelaClienteVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 82);
            Controls.Add(btCancelar);
            Controls.Add(btOk);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tfNome);
            Controls.Add(tfCodigo);
            Name = "JanelaClienteVenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JanelaClienteVenda";
            Load += JanelaClienteVenda_Load;
            KeyDown += JanelaClienteVenda_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tfCodigo;
        private TextBox tfNome;
        private Label label1;
        private Label label2;
        private Button btOk;
        private Button btCancelar;
    }
}