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
            BtCancelar = new Button();
            BtConfirmar = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            TfId = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtCancelar);
            groupBox1.Controls.Add(BtConfirmar);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(TfId);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(677, 231);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações";
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
            // 
            // textBox2
            // 
            textBox2.Location = new Point(11, 123);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(233, 23);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 95);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(64, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(335, 23);
            textBox1.TabIndex = 2;
            // 
            // TfId
            // 
            TfId.Location = new Point(11, 46);
            TfId.Name = "TfId";
            TfId.Size = new Size(47, 23);
            TfId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 28);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuário";
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
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        public TextBox TfId;
        private Label label1;
    }
}