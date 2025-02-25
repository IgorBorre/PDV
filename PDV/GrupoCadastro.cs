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
    public partial class GrupoCadastro : Form
    {
        public GrupoCadastro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GrupoCadastroNovo grupoCadastroNovo = new GrupoCadastroNovo();
            grupoCadastroNovo.ShowDialog();
        }
    }
}
