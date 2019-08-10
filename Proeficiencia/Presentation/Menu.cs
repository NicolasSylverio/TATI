using System;
using System.Windows.Forms;

namespace Proeficiencia.Presentation
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void CadastraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new CadastroAlunos();

                form.ShowDialog(this);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro no Sistema", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EnviarArquivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new IncluirArquivo();

                form.ShowDialog(this);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro no Sistema", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
