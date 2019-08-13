using Proeficiencia.CrossCutting.Constants;
using Proeficiencia.CrossCutting.Models;
using Proeficiencia.Domain;
using Proeficiencia.Repository;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Proeficiencia.Presentation
{
    public partial class ValidarArquivos : Form
    {
        private readonly ControleDocumentoRepository _documentoRepository;

        public ValidarArquivos()
        {
            InitializeComponent();

            _documentoRepository = new ControleDocumentoRepository(new Context());

            if (_documentoRepository == null) throw new ArgumentNullException($"Falha ao carregar componentes da tela. parametro: {nameof(_documentoRepository)}");
        }

        private void ValidarArquivos_Load(object sender, EventArgs e)
        {
            CarregarTela();
        }

        private void CarregarTela()
        {
            var lista = new BindingList<ControleDocumento>();

            var documentos = _documentoRepository
                .GetAll()
                .Where(x => x.DataValidacao == null && !x.Erro)
                .Take(20);

            foreach (var item in documentos)
            {
                lista.Add(item);
            }

            dtgArquivos.DataSource = lista;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnBaixar_Click(object sender, EventArgs e)
        {
            try
            {
                var linha = dtgArquivos.SelectedRows[0].Cells;
                var nomeArquivo = linha[1].Value.ToString();
                var caminhoArquivo = linha[2].Value.ToString();

                using (var folder = new FolderBrowserDialog())
                {
                    var dialogResult = folder.ShowDialog(this);

                    if (dialogResult == DialogResult.OK)
                    {
                        var caminhoSelecionado = $"{folder.SelectedPath.ToString()}\\{DateTime.Now.ToString("yyyyMMddhhmmss")}-{nomeArquivo}";

                        File.Copy(caminhoArquivo, caminhoSelecionado);

                        MessageBox.Show($"Arquivo baixado no diretorio selecionado: {caminhoSelecionado}", "Aviso Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao baixar o arquivo. Erro: {ex.Message}", "Aviso Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAutorizar_Click(object sender, EventArgs e)
        {
            try
            {
                var linha = dtgArquivos.SelectedRows[0].Cells;
                var idArquivo = Convert.ToInt32(linha[0].Value);
                var nomeArquivo = linha[1].Value.ToString();
                var caminhoArquivo = linha[2].Value.ToString();
                var arquivoSistema = Directory.GetCurrentDirectory();

                var documento = _documentoRepository.GetById(idArquivo);

                if (arquivoSistema.IndexOf(Constants.SistemDebugPath) != 0)
                {
                    arquivoSistema = arquivoSistema.Replace(Constants.SistemDebugPath, Constants.SistemFileAutorizedPath + "\\" + nomeArquivo);
                }
                else if (arquivoSistema.IndexOf(Constants.SistemReleasePath) != 0)
                {
                    arquivoSistema = arquivoSistema.Replace(Constants.SistemReleasePath, Constants.SistemFileAutorizedPath + "\\" + nomeArquivo);
                }
                else
                {
                    throw new Exception("Caminho do Arquivo do sistema não especificado.");
                }

                if (documento.Erro) throw new Exception("Arquivo Bloqueado");
                if (documento.DataValidacao != null) throw new Exception("Arquivo Já Válidado");

                documento.DataValidacao = DateTime.Now;
                documento.IdUsuarioValidador = Logon.Id;
                documento.CaminhoArquivo = arquivoSistema;
                documento.MensagemControle = txtObservacao.Text;

                _documentoRepository.SaveChanges();

                File.Move(caminhoArquivo, arquivoSistema);

                MessageBox.Show("Arquivo Autorizado com sucesso.", "Aviso Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CarregarTela();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao autorizar o arquivo. Erro: {ex.Message}", "Aviso Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBloquear_Click(object sender, EventArgs e)
        {
            try
            {
                var linha = dtgArquivos.SelectedRows[0].Cells;
                var idArquivo = Convert.ToInt32(linha[0].Value);
                var nomeArquivo = linha[1].Value.ToString();
                var caminhoArquivo = linha[2].Value.ToString();
                var arquivoSistema = Directory.GetCurrentDirectory();

                var documento = _documentoRepository.GetById(idArquivo);

                if (arquivoSistema.IndexOf(Constants.SistemDebugPath) != 0)
                {
                    arquivoSistema = arquivoSistema.Replace(Constants.SistemDebugPath, Constants.SistemFileBloquedPath + "\\" + nomeArquivo);
                }
                else if (arquivoSistema.IndexOf(Constants.SistemReleasePath) != 0)
                {
                    arquivoSistema = arquivoSistema.Replace(Constants.SistemReleasePath, Constants.SistemFileBloquedPath + "\\" + nomeArquivo);
                }
                else
                {
                    throw new Exception("Caminho do Arquivo do sistema não especificado.");
                }

                if (documento.Erro) throw new Exception("Arquivo Bloqueado");
                if (documento.DataValidacao != null) throw new Exception("Arquivo Já Válidado");

                documento.DataValidacao = DateTime.Now;
                documento.IdUsuarioValidador = Logon.Id;
                documento.CaminhoArquivo = arquivoSistema;
                documento.Erro = true;
                documento.MensagemControle = txtObservacao.Text;

                _documentoRepository.SaveChanges();

                File.Move(caminhoArquivo, arquivoSistema);

                MessageBox.Show("Arquivo bloqueado com sucesso.", "Aviso Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CarregarTela();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao bloquear o arquivo. Erro: {ex.Message}", "Aviso Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Pesquisar()
        {
            try
            {
                var lista = new BindingList<ControleDocumento>();

                var documentos = _documentoRepository
                    .GetAll();

                if (rdbValidar.Checked)
                {
                    documentos = documentos
                        .Where(x => !x.Erro && x.DataValidacao == null);
                }
                else if (rdbValidados.Checked)
                {
                    documentos = documentos
                        .Where(x => !x.Erro && x.DataValidacao != null);
                }
                else if (rdbBloqueados.Checked)
                {
                    documentos = documentos
                        .Where(x => x.Erro);
                }
                else
                {
                    documentos = documentos
                        .Take(20);
                }

                foreach (var item in documentos)
                {
                    lista.Add(item);
                }

                dtgArquivos.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao pesquisar os arquivos. Erro: {ex.Message}", "Aviso Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RdbTodos_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void RdbBloqueados_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void RdbValidados_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void RdbValidar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }
    }
}