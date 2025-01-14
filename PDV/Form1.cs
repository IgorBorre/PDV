namespace PDV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastroGeralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroGeral form = new CadastroGeral();
            form.ShowDialog();
        }
    }
}
