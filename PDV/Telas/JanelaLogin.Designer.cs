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
            BtEntrar = new Button();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            TfSenha = new TextBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            TfUsuario = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(BtEntrar);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(498, 429);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // BtEntrar
            // 
            BtEntrar.BackColor = Color.RoyalBlue;
            BtEntrar.FlatAppearance.BorderSize = 0;
            BtEntrar.FlatStyle = FlatStyle.Flat;
            BtEntrar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtEntrar.ForeColor = SystemColors.Control;
            BtEntrar.Image = Properties.Resources.log_in;
            BtEntrar.ImageAlign = ContentAlignment.MiddleRight;
            BtEntrar.Location = new Point(190, 367);
            BtEntrar.Name = "BtEntrar";
            BtEntrar.Size = new Size(114, 32);
            BtEntrar.TabIndex = 3;
            BtEntrar.Text = "Entrar";
            BtEntrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtEntrar.UseVisualStyleBackColor = false;
            BtEntrar.Click += BtEntrar_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(TfSenha);
            panel2.Location = new Point(25, 311);
            panel2.Name = "panel2";
            panel2.Size = new Size(457, 23);
            panel2.TabIndex = 10;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._lock;
            pictureBox3.Location = new Point(-1, -1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(23, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // TfSenha
            // 
            TfSenha.BorderStyle = BorderStyle.None;
            TfSenha.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TfSenha.Location = new Point(23, 3);
            TfSenha.Name = "TfSenha";
            TfSenha.Size = new Size(437, 16);
            TfSenha.TabIndex = 4;
            TfSenha.Text = "Senha";
            TfSenha.Enter += TfSenha_Enter;
            TfSenha.Leave += TfSenha_Leave;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(TfUsuario);
            panel1.Location = new Point(25, 234);
            panel1.Name = "panel1";
            panel1.Size = new Size(457, 23);
            panel1.TabIndex = 9;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(-1, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(23, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // TfUsuario
            // 
            TfUsuario.BorderStyle = BorderStyle.None;
            TfUsuario.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TfUsuario.Location = new Point(23, 3);
            TfUsuario.Name = "TfUsuario";
            TfUsuario.Size = new Size(420, 16);
            TfUsuario.TabIndex = 2;
            TfUsuario.Text = "Nome de usuário";
            TfUsuario.Enter += TfUsuario_Enter;
            TfUsuario.Leave += TfUsuario_Leave;
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
            // JanelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(506, 435);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "JanelaLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Panel panel1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private PictureBox pictureBox3;
    }
}