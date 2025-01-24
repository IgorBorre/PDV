namespace PDV
{
    partial class CadastroEstoqueNovo
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
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 14);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(72, 11);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 50);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "Referência";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(72, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(463, 23);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 86);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 4;
            label3.Text = "Descrição";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(72, 83);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(463, 23);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 121);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 6;
            label4.Text = "Grupo";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(72, 118);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(247, 23);
            textBox4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 160);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 8;
            label5.Text = "Estoque";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(72, 157);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 198);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 10;
            label6.Text = "Preço";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(72, 195);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 11;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.verifica__2___1_;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(30, 370);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.cancelar__1_;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(150, 370);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 13;
            button2.Text = "    Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // CadastroEstoqueNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 406);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "CadastroEstoqueNovo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroEstoqueNovo";
            Load += CadastroEstoqueNovo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox6;
        private Button button1;
        private Button button2;
    }
}