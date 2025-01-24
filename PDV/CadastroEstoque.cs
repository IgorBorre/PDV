using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV
{
    public partial class CadastroEstoque : Form
    {
        public CadastroEstoque()
        {
            InitializeComponent();
        }

        private void CadastroEstoque_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {

                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CadastroEstoqueNovo cadastroEstoqueNovo = new CadastroEstoqueNovo();
            cadastroEstoqueNovo.ShowDialog();   
        }
    }
}
