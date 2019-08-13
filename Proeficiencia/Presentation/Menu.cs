using Proeficiencia.Domain;
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
                if (Logon.Tipo != 1)
                {
                    MessageBox.Show("Usuário sem permissão para acessar a rotina.", "Aviso Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (var form = new CadastroAlunos())
                {
                    form.ShowDialog(this);
                }
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
                using (var form = new IncluirArquivo())
                {
                    form.ShowDialog(this);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro no Sistema", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidarArquivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Logon.Tipo != 1)
                {
                    MessageBox.Show("Usuário sem permissão para acessar a rotina.", "Aviso Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (var form = new ValidarArquivos())
                {
                    form.ShowDialog(this);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro no Sistema", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new ConsultaArquivos())
                {
                    form.ShowDialog(this);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro no Sistema", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ManutençãoAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Logon.Tipo != 1)
                {
                    MessageBox.Show("Usuário sem permissão para acessar a rotina.", "Aviso Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (var form = new ManutencaoAluno())
                {
                    form.ShowDialog(this);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro no Sistema", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultaAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Logon.Tipo != 1)
                {
                    MessageBox.Show("Usuário sem permissão para acessar a rotina.", "Aviso Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (var form = new ConsultaAlunos())
                {
                    form.ShowDialog(this);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro no Sistema", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
