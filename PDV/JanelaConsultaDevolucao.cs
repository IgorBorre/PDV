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
    public partial class JanelaConsultaDevolucao : Form
    {
        public JanelaConsultaDevolucao()
        {
            InitializeComponent();
        }

        private void JanelaConsultaDevolucao_Load(object sender, EventArgs e)
        {
            TfData1.Text = DateTime.Now.ToString("dd/MM/yyyy");
            TfData2.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
