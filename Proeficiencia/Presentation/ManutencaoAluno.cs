using Proeficiencia.CrossCutting.Enum;
using Proeficiencia.Repository;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Proeficiencia.Presentation
{
    public partial class ManutencaoAluno : Form
    {
        private readonly AlunoRepository _alunoRepository;

        public ManutencaoAluno()
        {
            InitializeComponent();

            _alunoRepository = new AlunoRepository(new Context());

            if (_alunoRepository == null) throw new ArgumentNullException($"Falha ao carregar componentes da tela. parametro: {nameof(_alunoRepository)}");
        }

        private void ManutencaoAluno_Load(object sender, EventArgs e)
        {
            dtpDataNascimento.Value = DateTime.Now.Date;

            var comboList = new BindingList<object>
            {
                new { Id = 0, Descricao = "Selecion o Curso" },
                new { Id = 1, Descricao = "Gestão de TI" },
                new { Id = 2, Descricao = "Análise e Desenv. de Sistemas" },
                new { Id = 3, Descricao = "Eventos" },
                new { Id = 4, Descricao = "Logistica" },
                new { Id = 5, Descricao = "Gestão Ambiental" }
            };

            cmbCursos.DataSource = comboList;
            cmbCursos.ValueMember = "Descricao";
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                var aluno = _alunoRepository.GetById(Convert.ToInt32(txtId.Text));

                if (aluno == null) throw new Exception("Aluno não encontrado.");

                txtNome.Text = aluno.Nome;
                txtRa.Text = aluno.RA;
                dtpDataNascimento.Value = aluno.Nascimento;
                cmbCursos.SelectedIndex = (int)aluno.Curso;
                ckbMatriculado.Checked = aluno.Matriculado;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                (
                    $"Erro ao Pesquisar Aluno: {ex.Message}",
                    "Aviso Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void LimparTela()
        {
            try
            {
                txtNome.Text = string.Empty;
                txtRa.Text = string.Empty;
                dtpDataNascimento.Value = DateTime.Now.Date;
                cmbCursos.SelectedIndex = 0;
                ckbMatriculado.Checked = false;

                txtNome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show
                (
                    $"Erro ao Limpar Tela: {ex.Message}",
                    "Aviso Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (_alunoRepository.GetById(Convert.ToInt32(txtId.Text)) == null) throw new Exception("Aluno não encontrado");

                _alunoRepository.Remove(Convert.ToInt32(txtId.Text));

                LimparTela();
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                        $"Erro ao Excluir Aluno: {ex.Message}",
                        "Aviso Sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            _alunoRepository.Dispose();

            Close();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                var aluno = _alunoRepository.GetById(Convert.ToInt32(txtId.Text));

                aluno.Nome = txtNome.Text;
                aluno.RA = txtRa.Text;
                aluno.Nascimento = dtpDataNascimento.Value;
                aluno.Curso = (Cursos)cmbCursos.SelectedIndex;
                aluno.Matriculado = ckbMatriculado.Checked;

                _alunoRepository.SaveChanges();

                LimparTela();
            }
            catch (Exception)
            {

            }
        }
    }
}