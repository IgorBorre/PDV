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
            TfSubtotal.Size = new Size(152, 23);
            TfSubtotal.TabIndex = 1;
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
            // 
            // TfAcrescimo
            // 
            TfAcrescimo.Location = new Point(114, 117);
            TfAcrescimo.Name = "TfAcrescimo";
            TfAcrescimo.Size = new Size(152, 23);
            TfAcrescimo.TabIndex = 4;
            // 
            // TfTotal
            // 
            TfTotal.Location = new Point(114, 159);
            TfTotal.Name = "TfTotal";
            TfTotal.Size = new Size(152, 23);
            TfTotal.TabIndex = 5;
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
            // 
            // JanelaDesconto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 256);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TfSubtotal;
        private Label label2;
        private TextBox TfDesconto;
        private TextBox TfAcrescimo;
        private TextBox TfTotal;
        private Label label3;
        private Label label4;
        private Button btOK;
        private Button btCancelar;
    }
}