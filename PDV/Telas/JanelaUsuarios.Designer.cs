namespace PDV.Telas
{
    partial class JanelaUsuarios
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
            BtLimpar = new Button();
            BtProcurar = new Button();
            TfUsuario = new TextBox();
            TfId = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            usuario = new DataGridViewTextBoxColumn();
            BtInserir = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtInserir);
            groupBox1.Controls.Add(BtLimpar);
            groupBox1.Controls.Add(BtProcurar);
            groupBox1.Controls.Add(TfUsuario);
            groupBox1.Controls.Add(TfId);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(722, 104);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // BtLimpar
            // 
            BtLimpar.Image = Properties.Resources.lixeira_de_reciclagem__1_;
            BtLimpar.ImageAlign = ContentAlignment.MiddleLeft;
            BtLimpar.Location = new Point(608, 44);
            BtLimpar.Name = "BtLimpar";
            BtLimpar.Size = new Size(75, 23);
            BtLimpar.TabIndex = 4;
            BtLimpar.Text = "   Limpar";
            BtLimpar.UseVisualStyleBackColor = true;
            // 
            // BtProcurar
            // 
            BtProcurar.Image = Properties.Resources.lupa_de_pesquisa__1___1___1_;
            BtProcurar.ImageAlign = ContentAlignment.MiddleLeft;
            BtProcurar.Location = new Point(608, 14);
            BtProcurar.Name = "BtProcurar";
            BtProcurar.Size = new Size(75, 23);
            BtProcurar.TabIndex = 3;
            BtProcurar.Text = "Procurar";
            BtProcurar.TextAlign = ContentAlignment.MiddleRight;
            BtProcurar.UseVisualStyleBackColor = true;
            // 
            // TfUsuario
            // 
            TfUsuario.Location = new Point(64, 40);
            TfUsuario.Name = "TfUsuario";
            TfUsuario.Size = new Size(293, 23);
            TfUsuario.TabIndex = 2;
            // 
            // TfId
            // 
            TfId.Location = new Point(12, 40);
            TfId.Name = "TfId";
            TfId.Size = new Size(46, 23);
            TfId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 22);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuário";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { codigo, usuario });
            dataGridView1.Location = new Point(11, 110);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(703, 334);
            dataGridView1.TabIndex = 5;
            // 
            // codigo
            // 
            codigo.DataPropertyName = "codigo";
            codigo.FillWeight = 30.456852F;
            codigo.HeaderText = "Código";
            codigo.Name = "codigo";
            codigo.ReadOnly = true;
            // 
            // usuario
            // 
            usuario.DataPropertyName = "usuario";
            usuario.FillWeight = 169.543152F;
            usuario.HeaderText = "Usuário";
            usuario.Name = "usuario";
            usuario.ReadOnly = true;
            // 
            // BtInserir
            // 
            BtInserir.Image = Properties.Resources.adicionar_usuario__1_1;
            BtInserir.ImageAlign = ContentAlignment.MiddleLeft;
            BtInserir.Location = new Point(608, 73);
            BtInserir.Name = "BtInserir";
            BtInserir.Size = new Size(75, 23);
            BtInserir.TabIndex = 5;
            BtInserir.Text = "  Inserir";
            BtInserir.UseVisualStyleBackColor = true;
            BtInserir.Click += BtInserir_Click;
            // 
            // JanelaUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 462);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "JanelaUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JanelaUsuarios";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox TfUsuario;
        private TextBox TfId;
        private Label label1;
        private Button BtProcurar;
        private Button BtLimpar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn usuario;
        private Button BtInserir;
    }
}