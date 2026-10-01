namespace PDV.Telas
{
    partial class JanelaUsuarioNovo
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
            label3 = new Label();
            label1 = new Label();
            BtCancelar = new Button();
            BtConfirmar = new Button();
            TfSenha = new TextBox();
            label2 = new Label();
            TfUsuario = new TextBox();
            TfId = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(BtCancelar);
            groupBox1.Controls.Add(BtConfirmar);
            groupBox1.Controls.Add(TfSenha);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TfUsuario);
            groupBox1.Controls.Add(TfId);
            groupBox1.Location = new Point(12, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(677, 231);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(11, 70);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 8;
            label3.Text = "Nome de usuário";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 18);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 7;
            label1.Text = "Código";
            // 
            // BtCancelar
            // 
            BtCancelar.Image = Properties.Resources.cancelar__1_;
            BtCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            BtCancelar.Location = new Point(323, 191);
            BtCancelar.Name = "BtCancelar";
            BtCancelar.Size = new Size(76, 23);
            BtCancelar.TabIndex = 6;
            BtCancelar.Text = "Cancelar";
            BtCancelar.TextAlign = ContentAlignment.MiddleRight;
            BtCancelar.UseVisualStyleBackColor = true;
            BtCancelar.Click += BtCancelar_Click;
            // 
            // BtConfirmar
            // 
            BtConfirmar.Image = Properties.Resources.verifica__2___1_;
            BtConfirmar.ImageAlign = ContentAlignment.MiddleLeft;
            BtConfirmar.Location = new Point(194, 191);
            BtConfirmar.Name = "BtConfirmar";
            BtConfirmar.Size = new Size(86, 23);
            BtConfirmar.TabIndex = 5;
            BtConfirmar.Text = "Confirmar";
            BtConfirmar.TextAlign = ContentAlignment.MiddleRight;
            BtConfirmar.UseVisualStyleBackColor = true;
            BtConfirmar.Click += BtConfirmar_Click;
            // 
            // TfSenha
            // 
            TfSenha.Location = new Point(11, 141);
            TfSenha.Name = "TfSenha";
            TfSenha.Size = new Size(233, 23);
            TfSenha.TabIndex = 4;
            TfSenha.TextChanged += TfSenha_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 123);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // TfUsuario
            // 
            TfUsuario.Location = new Point(11, 88);
            TfUsuario.Name = "TfUsuario";
            TfUsuario.Size = new Size(335, 23);
            TfUsuario.TabIndex = 2;
            // 
            // TfId
            // 
            TfId.Enabled = false;
            TfId.Location = new Point(11, 36);
            TfId.Name = "TfId";
            TfId.Size = new Size(47, 23);
            TfId.TabIndex = 1;
            // 
            // JanelaUsuarioNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 245);
            Controls.Add(groupBox1);
            Name = "JanelaUsuarioNovo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Usuários";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button BtCancelar;
        private Button BtConfirmar;
        private TextBox TfSenha;
        private Label label2;
        private TextBox TfUsuario;
        public TextBox TfId;
        private Label label3;
        private Label label1;
    }
}