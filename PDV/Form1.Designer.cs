﻿namespace PDV
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            cadastroGeralToolStripMenuItem = new ToolStripMenuItem();
            estoqueToolStripMenuItem = new ToolStripMenuItem();
            gruposToolStripMenuItem = new ToolStripMenuItem();
            peçasToolStripMenuItem = new ToolStripMenuItem();
            saídaToolStripMenuItem = new ToolStripMenuItem();
            vendaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, peçasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1370, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroGeralToolStripMenuItem, estoqueToolStripMenuItem, gruposToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // cadastroGeralToolStripMenuItem
            // 
            cadastroGeralToolStripMenuItem.Name = "cadastroGeralToolStripMenuItem";
            cadastroGeralToolStripMenuItem.Size = new Size(151, 22);
            cadastroGeralToolStripMenuItem.Text = "Cadastro Geral";
            cadastroGeralToolStripMenuItem.Click += cadastroGeralToolStripMenuItem_Click;
            // 
            // estoqueToolStripMenuItem
            // 
            estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            estoqueToolStripMenuItem.Size = new Size(151, 22);
            estoqueToolStripMenuItem.Text = "Estoque";
            estoqueToolStripMenuItem.Click += estoqueToolStripMenuItem_Click;
            // 
            // gruposToolStripMenuItem
            // 
            gruposToolStripMenuItem.Name = "gruposToolStripMenuItem";
            gruposToolStripMenuItem.Size = new Size(151, 22);
            gruposToolStripMenuItem.Text = "Grupos";
            gruposToolStripMenuItem.Click += gruposToolStripMenuItem_Click;
            // 
            // peçasToolStripMenuItem
            // 
            peçasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saídaToolStripMenuItem });
            peçasToolStripMenuItem.Name = "peçasToolStripMenuItem";
            peçasToolStripMenuItem.Size = new Size(49, 20);
            peçasToolStripMenuItem.Text = "Peças";
            // 
            // saídaToolStripMenuItem
            // 
            saídaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { vendaToolStripMenuItem });
            saídaToolStripMenuItem.Name = "saídaToolStripMenuItem";
            saídaToolStripMenuItem.Size = new Size(180, 22);
            saídaToolStripMenuItem.Text = "Saída";
            // 
            // vendaToolStripMenuItem
            // 
            vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            vendaToolStripMenuItem.Size = new Size(180, 22);
            vendaToolStripMenuItem.Text = "Venda";
            vendaToolStripMenuItem.Click += vendaToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem cadastroGeralToolStripMenuItem;
        private ToolStripMenuItem estoqueToolStripMenuItem;
        private ToolStripMenuItem gruposToolStripMenuItem;
        private ToolStripMenuItem peçasToolStripMenuItem;
        private ToolStripMenuItem saídaToolStripMenuItem;
        private ToolStripMenuItem vendaToolStripMenuItem;
    }
}
