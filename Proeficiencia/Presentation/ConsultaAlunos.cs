using Proeficiencia.CrossCutting.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Proeficiencia.Presentation
{
    public partial class ConsultaAlunos : Form
    {
        public ConsultaAlunos()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                var listaAlunos = new List<Aluno>();

                if (rdbNome.Checked)
                {
                    listaAlunos = CarregarAlunoPorNome().ToList();
                }
                else
                {
                    listaAlunos = CarregarAlunoPorRa().ToList();
                }

                var dataGridData = new BindingList<Aluno>(listaAlunos);

                if (!dataGridData.Any())
                {
                    MessageBox.Show(this, "Nenhum aluno encontrado.", "Aviso Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvAluno.Rows.Clear();
                    return;
                }

                dgvAluno.DataSource = dataGridData;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private IEnumerable<Aluno> CarregarAlunoPorNome()
        {


            return new List<Aluno>();
        }

        private IEnumerable<Aluno> CarregarAlunoPorRa()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
                throw new Exception();

            return new List<Aluno>();
        }
    }
}
