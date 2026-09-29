namespace PDV.Telas
{
    partial class JanelaLogin
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            TfSenha = new TextBox();
            BtEntrar = new Button();
            TfUsuario = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TfSenha);
            groupBox1.Controls.Add(BtEntrar);
            groupBox1.Controls.Add(TfUsuario);
            groupBox1.Location = new Point(131, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(498, 445);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.RoyalBlue;
            label1.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(228, 118);
            label1.Name = "label1";
            label1.Size = new Size(53, 30);
            label1.TabIndex = 8;
            label1.Text = "PDV";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.RoyalBlue;
            pictureBox1.Image = Properties.Resources.grocery_store__1_;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(498, 168);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 281);
            label3.Name = "label3";
            label3.Size = new Size(45, 17);
            label3.TabIndex = 6;
            label3.Text = "Senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 205);
            label2.Name = "label2";
            label2.Size = new Size(55, 17);
            label2.TabIndex = 5;
            label2.Text = "Usuário";
            // 
            // TfSenha
            // 
            TfSenha.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TfSenha.Location = new Point(25, 308);
            TfSenha.Name = "TfSenha";
            TfSenha.Size = new Size(441, 23);
            TfSenha.TabIndex = 4;
            TfSenha.Text = "      Senha";
            TfSenha.Enter += TfSenha_Enter;
            TfSenha.Leave += TfSenha_Leave;
            // 
            // BtEntrar
            // 
            BtEntrar.Location = new Point(63, 375);
            BtEntrar.Name = "BtEntrar";
            BtEntrar.Size = new Size(75, 23);
            BtEntrar.TabIndex = 3;
            BtEntrar.Text = "Entrar";
            BtEntrar.UseVisualStyleBackColor = true;
            BtEntrar.Click += BtEntrar_Click;
            // 
            // TfUsuario
            // 
            TfUsuario.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TfUsuario.Location = new Point(25, 232);
            TfUsuario.Name = "TfUsuario";
            TfUsuario.Size = new Size(441, 23);
            TfUsuario.TabIndex = 2;
            TfUsuario.Text = "      Nome de usuário";
            TfUsuario.Enter += TfUsuario_Enter;
            TfUsuario.Leave += TfUsuario_Leave;
            // 
            // JanelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(767, 518);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "JanelaLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox TfUsuario;
        private Button BtEntrar;
        private Label label2;
        private TextBox TfSenha;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
    }
}