namespace PDV
{
    partial class JanelaDesconto
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
            TfSubtotal = new TextBox();
            label2 = new Label();
            TfDesconto = new TextBox();
            TfAcrescimo = new TextBox();
            TfTotal = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btOK = new Button();
            btCancelar = new Button();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 30);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 0;
            label1.Text = "Subtotal";
            // 
            // TfSubtotal
            // 
            TfSubtotal.Location = new Point(114, 32);
            TfSubtotal.Name = "TfSubtotal";
            TfSubtotal.ReadOnly = true;
            TfSubtotal.Size = new Size(152, 23);
            TfSubtotal.TabIndex = 1;
            TfSubtotal.Leave += TfSubtotal_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 73);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 2;
            label2.Text = "Desconto";
            // 
            // TfDesconto
            // 
            TfDesconto.Location = new Point(114, 75);
            TfDesconto.Name = "TfDesconto";
            TfDesconto.Size = new Size(152, 23);
            TfDesconto.TabIndex = 3;
            TfDesconto.TextChanged += TfDesconto_TextChanged;
            TfDesconto.Leave += TfDesconto_Leave;
            // 
            // TfAcrescimo
            // 
            TfAcrescimo.Location = new Point(114, 117);
            TfAcrescimo.Name = "TfAcrescimo";
            TfAcrescimo.Size = new Size(152, 23);
            TfAcrescimo.TabIndex = 4;
            TfAcrescimo.TextChanged += TfAcrescimo_TextChanged;
            TfAcrescimo.Leave += TfAcrescimo_Leave;
            // 
            // TfTotal
            // 
            TfTotal.Location = new Point(114, 159);
            TfTotal.Name = "TfTotal";
            TfTotal.Size = new Size(152, 23);
            TfTotal.TabIndex = 5;
            TfTotal.TextChanged += TfTotal_TextChanged;
            TfTotal.Leave += TfTotal_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 115);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 6;
            label3.Text = "Acréscimo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(52, 157);
            label4.Name = "label4";
            label4.Size = new Size(42, 21);
            label4.TabIndex = 7;
            label4.Text = "Total";
            // 
            // btOK
            // 
            btOK.Image = Properties.Resources.verifica__2___1_;
            btOK.ImageAlign = ContentAlignment.MiddleLeft;
            btOK.Location = new Point(46, 221);
            btOK.Name = "btOK";
            btOK.Size = new Size(75, 23);
            btOK.TabIndex = 8;
            btOK.Text = "Ok";
            btOK.UseVisualStyleBackColor = true;
            btOK.Click += btOK_Click;
            // 
            // btCancelar
            // 
            btCancelar.Image = Properties.Resources.cancelar__1_;
            btCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btCancelar.Location = new Point(171, 221);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(75, 23);
            btCancelar.TabIndex = 9;
            btCancelar.Text = "Cancelar";
            btCancelar.TextAlign = ContentAlignment.MiddleRight;
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(272, 75);
            label5.Name = "label5";
            label5.Size = new Size(23, 21);
            label5.TabIndex = 10;
            label5.Text = "%";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(272, 117);
            label6.Name = "label6";
            label6.Size = new Size(23, 21);
            label6.TabIndex = 11;
            label6.Text = "%";
            // 
            // JanelaDesconto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 256);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btCancelar);
            Controls.Add(btOK);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(TfTotal);
            Controls.Add(TfAcrescimo);
            Controls.Add(TfDesconto);
            Controls.Add(label2);
            Controls.Add(TfSubtotal);
            Controls.Add(label1);
            Name = "JanelaDesconto";
            StartPosition = FormStartPosition.CenterScreen;
            Load += JanelaDesconto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TfDesconto;
        private TextBox TfAcrescimo;
        private Label label3;
        private Label label4;
        private Button btOK;
        private Button btCancelar;
        public TextBox TfSubtotal;
        private Label label5;
        private Label label6;
        public TextBox TfTotal;
    }
}