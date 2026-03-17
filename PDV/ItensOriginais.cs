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
    public partial class ItensOriginais : Form
    {
        public ItensOriginais()
        {
            InitializeComponent();
        }

        private void ItensOriginais_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            
        }
    }
}
