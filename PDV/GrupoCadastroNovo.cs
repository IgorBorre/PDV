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
    public partial class GrupoCadastroNovo : Form
    {
        private GrupoDAO grupodao;
        public GrupoCadastroNovo()
        {
            InitializeComponent();
            grupodao = new GrupoDAO();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Grupo g = new Grupo();
            g.nome = TfNome.Text;

            if (grupodao.Validacoes(g))
            {
                if (string.IsNullOrEmpty(TfCodigo.Text))
                {
                    grupodao.InserirGrupo(g);
                    TfCodigo.Text = g.id.ToString();
                }
                else
                {
                    g.id = int.Parse(TfCodigo.Text);
                    grupodao.AtualizarGrupo(g);
                }
            }
        }

        private void GrupoCadastroNovo_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TfCodigo.Text))
            {
                DataTable dt = grupodao.BuscarGrupoById(TfCodigo.Text);
                DataRow row = null;
                row = dt.Rows[0];

                TfNome.Text = row["nome"].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
