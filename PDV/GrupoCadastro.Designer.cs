﻿namespace PDV
{
    partial class GrupoCadastro
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
            TfId = new TextBox();
            TfNome = new TextBox();
            Código = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // TfId
            // 
            TfId.Location = new Point(10, 38);
            TfId.Name = "TfId";
            TfId.Size = new Size(41, 23);
            TfId.TabIndex = 0;
            // 
            // TfNome
            // 
            TfNome.Location = new Point(66, 38);
            TfNome.Name = "TfNome";
            TfNome.Size = new Size(268, 23);
            TfNome.TabIndex = 1;
            // 
            // Código
            // 
            Código.AutoSize = true;
            Código.Location = new Point(5, 20);
            Código.Name = "Código";
            Código.Size = new Size(46, 15);
            Código.TabIndex = 2;
            Código.Text = "Código";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 20);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 3;
            label1.Text = "Nome";
            // 
            // button1
            // 
            button1.Image = Properties.Resources.lupa__1_;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(384, 20);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Procurar";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.inserir__2___1_;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(384, 49);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = " Inserir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, Column2 });
            dataGridView1.Location = new Point(5, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(454, 346);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.Sorted += dataGridView1_Sorted;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.FillWeight = 30.456852F;
            id.HeaderText = "Código";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "nome";
            Column2.FillWeight = 169.543152F;
            Column2.HeaderText = "Nome";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // GrupoCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(Código);
            Controls.Add(TfNome);
            Controls.Add(TfId);
            Name = "GrupoCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GrupoCadastro";
            Load += GrupoCadastro_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TfId;
        private TextBox TfNome;
        private Label Código;
        private Label label1;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Column2;
    }
}