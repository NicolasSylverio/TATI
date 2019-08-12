using Proeficiencia.CrossCutting.Models;
using Proeficiencia.Domain;
using Proeficiencia.Repository;
using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Proeficiencia.Presentation
{
    public partial class ConsultaArquivos : Form
    {
        private readonly ControleDocumentoRepository _documentoRepository;

        public ConsultaArquivos()
        {
            InitializeComponent();

            _documentoRepository = new ControleDocumentoRepository(new Context());

            if (_documentoRepository == null) throw new ArgumentNullException($"Falha ao carregar componentes da tela. parametro: {nameof(_documentoRepository)}");
        }

        private void ConsultaArquivos_Load(object sender, EventArgs e)
        {
            CarregarTela();
        }

        private void CarregarTela()
        {
            var lista = new BindingList<ControleDocumento>();

            var documentos = _documentoRepository
                .GetAll()
                .Where(x => x.DataValidacao == null && !x.Erro && x.IdUsuarioEnvio == Logon.Id)
                .Take(20);

            foreach (var item in documentos)
            {
                lista.Add(item);
            }

            dtgArquivos.DataSource = lista;
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
                        .Where(x => !x.Erro && x.DataValidacao == null && x.IdUsuarioEnvio == Logon.Id)
                        .Take(20);
                }
                else if (rdbValidados.Checked)
                {
                    documentos = documentos
                        .Where(x => !x.Erro && x.DataValidacao != null && x.IdUsuarioEnvio == Logon.Id)
                        .Take(20);
                }
                else if (rdbBloqueados.Checked)
                {
                    documentos = documentos
                        .Where(x => x.Erro && x.IdUsuarioEnvio == Logon.Id)
                        .Take(20);
                }
                else
                {
                    documentos = documentos
                        .Where(x => x.IdUsuarioEnvio == Logon.Id)
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

        private void RdbBloqueados_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void RdbTodos_Click(object sender, EventArgs e)
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
