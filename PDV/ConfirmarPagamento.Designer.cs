namespace PDV
{
    partial class ConfirmarPagamento
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
            TfValor = new TextBox();
            label2 = new Label();
            TfParcelas = new TextBox();
            BtOk = new Button();
            BtCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 14);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 0;
            label1.Text = "Valor";
            // 
            // TfValor
            // 
            TfValor.Location = new Point(87, 14);
            TfValor.Name = "TfValor";
            TfValor.Size = new Size(170, 23);
            TfValor.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(7, 50);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 2;
            label2.Text = "Parcelas";
            // 
            // TfParcelas
            // 
            TfParcelas.Location = new Point(87, 51);
            TfParcelas.Name = "TfParcelas";
            TfParcelas.Size = new Size(74, 23);
            TfParcelas.TabIndex = 3;
            TfParcelas.Text = "1";
            // 
            // BtOk
            // 
            BtOk.Image = Properties.Resources.verifica__2___1_;
            BtOk.ImageAlign = ContentAlignment.MiddleRight;
            BtOk.Location = new Point(23, 112);
            BtOk.Name = "BtOk";
            BtOk.Size = new Size(75, 23);
            BtOk.TabIndex = 4;
            BtOk.Text = "Ok";
            BtOk.UseVisualStyleBackColor = true;
            BtOk.Click += BtOk_Click;
            // 
            // BtCancelar
            // 
            BtCancelar.Image = Properties.Resources.cancelar__1_;
            BtCancelar.ImageAlign = ContentAlignment.MiddleRight;
            BtCancelar.Location = new Point(122, 112);
            BtCancelar.Name = "BtCancelar";
            BtCancelar.Size = new Size(75, 23);
            BtCancelar.TabIndex = 5;
            BtCancelar.Text = "Cancelar";
            BtCancelar.TextAlign = ContentAlignment.MiddleLeft;
            BtCancelar.UseVisualStyleBackColor = true;
            BtCancelar.Click += BtCancelar_Click;
            // 
            // ConfirmarPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 142);
            Controls.Add(BtCancelar);
            Controls.Add(BtOk);
            Controls.Add(TfParcelas);
            Controls.Add(label2);
            Controls.Add(TfValor);
            Controls.Add(label1);
            Name = "ConfirmarPagamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConfirmarPagamento";
            Load += ConfirmarPagamento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button BtOk;
        private Button BtCancelar;
        public TextBox TfValor;
        public TextBox TfParcelas;
    }
}