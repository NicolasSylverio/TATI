using Proeficiencia.CrossCutting.Models;
using Proeficiencia.Repository;
using System;
using System.Windows.Forms;

namespace Proeficiencia.Presentation
{
    public partial class CadastroAlunos : Form
    {
        private readonly AlunoRepository _alunoRepository;
        private readonly Context _context;

        public CadastroAlunos()
        {
            InitializeComponent();

            _context = new Context();
            _alunoRepository = new AlunoRepository(_context);
        }

        private void CadastroAlunos_Load(object sender, EventArgs e)
        {
            dtpDataNascimento.Value = DateTime.Now.Date;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos()) throw new Exception("Campos Obrigatórios não preenchidos ou selecionados.");

                var aluno = new Aluno
                {
                    Nome = txtNome.Text,
                    RA = txtRa.Text,
                    Nascimento = dtpDataNascimento.Value,
                    Curso = 0,
                    Matriculado = ckbMatriculado.Checked
                };

                _alunoRepository.Add(aluno);

                LimparTela();

                MessageBox.Show
                (
                    "Aluno Cadastrado Com Sucesso",
                    "Aviso Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show
                (
                    $"Erro ao Cadastrar Aluno: {ex.Message}",
                    "Aviso Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparTela();
        }

        private void LimparTela()
        {
            try
            {
                txtNome.Text = string.Empty;
                txtRa.Text = string.Empty;
                dtpDataNascimento.Value = DateTime.Now.Date;
                //cmbCursos.SelectedIndex = 0;
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

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text)) return false;

            if (string.IsNullOrWhiteSpace(txtRa.Text)) return false;

            return true;
        }
    }
}