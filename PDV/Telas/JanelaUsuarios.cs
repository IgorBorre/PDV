using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV.Telas
{
    public partial class JanelaUsuarios : Form
    {
        public JanelaUsuarios()
        {
            InitializeComponent();
        }

        private void BtInserir_Click(object sender, EventArgs e)
        {
            JanelaUsuarioNovo janelaUsuarioNovo = new();
            janelaUsuarioNovo.Show();
        }
    }
}
