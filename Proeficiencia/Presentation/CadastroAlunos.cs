﻿using Proeficiencia.CrossCutting.Enum;
using Proeficiencia.CrossCutting.Models;
using Proeficiencia.Repository;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Proeficiencia.Presentation
{
    public partial class CadastroAlunos : Form
    {
        private readonly AlunoRepository _alunoRepository;

        public CadastroAlunos()
        {
            InitializeComponent();

            _alunoRepository = new AlunoRepository(new Context());
        }

        private void CadastroAlunos_Load(object sender, EventArgs e)
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
            cmbCursos.ValueMember = "Id";
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
                    Curso = (Cursos)cmbCursos.SelectedIndex,
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

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text)) return false;

            if (string.IsNullOrWhiteSpace(txtRa.Text)) return false;

            return true;
        }
    }
}