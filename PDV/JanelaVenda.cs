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
    public partial class JanelaVenda : Form
    {
        public JanelaVenda()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void JanelaVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.F3)
            {
                F3.PerformClick();
            }

            if (e.KeyCode == Keys.F4)
            {
                F4.PerformClick();
            }

            if (e.KeyCode == Keys.F5)
            {
                F5.PerformClick();
            }

            if (e.KeyCode == Keys.F6)
            {
                F5.PerformClick();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void F4_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void F5_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void F6_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void F5_Click(object sender, EventArgs e)
        {
           
        }
    }
}
