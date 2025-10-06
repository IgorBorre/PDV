namespace PDV
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
            entradaToolStripMenuItem = new ToolStripMenuItem();
            lançamentoDeEntradasToolStripMenuItem = new ToolStripMenuItem();
            consultaDeEntradasToolStripMenuItem = new ToolStripMenuItem();
            saídaToolStripMenuItem = new ToolStripMenuItem();
            vendaToolStripMenuItem = new ToolStripMenuItem();
            consultaDeSaídasToolStripMenuItem = new ToolStripMenuItem();
            caixaToolStripMenuItem = new ToolStripMenuItem();
            formasDePagamentoToolStripMenuItem = new ToolStripMenuItem();
            cancelamentoDeSaídasToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, peçasToolStripMenuItem, caixaToolStripMenuItem });
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
            peçasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { entradaToolStripMenuItem, saídaToolStripMenuItem });
            peçasToolStripMenuItem.Name = "peçasToolStripMenuItem";
            peçasToolStripMenuItem.Size = new Size(49, 20);
            peçasToolStripMenuItem.Text = "Peças";
            // 
            // entradaToolStripMenuItem
            // 
            entradaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lançamentoDeEntradasToolStripMenuItem, consultaDeEntradasToolStripMenuItem });
            entradaToolStripMenuItem.Name = "entradaToolStripMenuItem";
            entradaToolStripMenuItem.Size = new Size(180, 22);
            entradaToolStripMenuItem.Text = "Entrada";
            // 
            // lançamentoDeEntradasToolStripMenuItem
            // 
            lançamentoDeEntradasToolStripMenuItem.Name = "lançamentoDeEntradasToolStripMenuItem";
            lançamentoDeEntradasToolStripMenuItem.Size = new Size(204, 22);
            lançamentoDeEntradasToolStripMenuItem.Text = "Lançamento de entradas";
            lançamentoDeEntradasToolStripMenuItem.Click += lançamentoDeEntradasToolStripMenuItem_Click;
            // 
            // consultaDeEntradasToolStripMenuItem
            // 
            consultaDeEntradasToolStripMenuItem.Name = "consultaDeEntradasToolStripMenuItem";
            consultaDeEntradasToolStripMenuItem.Size = new Size(204, 22);
            consultaDeEntradasToolStripMenuItem.Text = "Consulta de entradas";
            consultaDeEntradasToolStripMenuItem.Click += consultaDeEntradasToolStripMenuItem_Click;
            // 
            // saídaToolStripMenuItem
            // 
            saídaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { vendaToolStripMenuItem, consultaDeSaídasToolStripMenuItem, cancelamentoDeSaídasToolStripMenuItem });
            saídaToolStripMenuItem.Name = "saídaToolStripMenuItem";
            saídaToolStripMenuItem.Size = new Size(180, 22);
            saídaToolStripMenuItem.Text = "Saída";
            // 
            // vendaToolStripMenuItem
            // 
            vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            vendaToolStripMenuItem.Size = new Size(202, 22);
            vendaToolStripMenuItem.Text = "Venda";
            vendaToolStripMenuItem.Click += vendaToolStripMenuItem_Click;
            // 
            // consultaDeSaídasToolStripMenuItem
            // 
            consultaDeSaídasToolStripMenuItem.Name = "consultaDeSaídasToolStripMenuItem";
            consultaDeSaídasToolStripMenuItem.Size = new Size(202, 22);
            consultaDeSaídasToolStripMenuItem.Text = "Consulta de saídas";
            consultaDeSaídasToolStripMenuItem.Click += consultaDeSaídasToolStripMenuItem_Click;
            // 
            // caixaToolStripMenuItem
            // 
            caixaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { formasDePagamentoToolStripMenuItem });
            caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            caixaToolStripMenuItem.Size = new Size(47, 20);
            caixaToolStripMenuItem.Text = "Caixa";
            // 
            // formasDePagamentoToolStripMenuItem
            // 
            formasDePagamentoToolStripMenuItem.Name = "formasDePagamentoToolStripMenuItem";
            formasDePagamentoToolStripMenuItem.Size = new Size(193, 22);
            formasDePagamentoToolStripMenuItem.Text = "Formas de pagamento";
            formasDePagamentoToolStripMenuItem.Click += formasDePagamentoToolStripMenuItem_Click;
            // 
            // cancelamentoDeSaídasToolStripMenuItem
            // 
            cancelamentoDeSaídasToolStripMenuItem.Name = "cancelamentoDeSaídasToolStripMenuItem";
            cancelamentoDeSaídasToolStripMenuItem.Size = new Size(202, 22);
            cancelamentoDeSaídasToolStripMenuItem.Text = "Cancelamento de saídas";
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
        private ToolStripMenuItem caixaToolStripMenuItem;
        private ToolStripMenuItem formasDePagamentoToolStripMenuItem;
        private ToolStripMenuItem entradaToolStripMenuItem;
        private ToolStripMenuItem lançamentoDeEntradasToolStripMenuItem;
        private ToolStripMenuItem consultaDeSaídasToolStripMenuItem;
        private ToolStripMenuItem consultaDeEntradasToolStripMenuItem;
        private ToolStripMenuItem cancelamentoDeSaídasToolStripMenuItem;
    }
}
