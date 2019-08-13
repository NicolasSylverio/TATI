using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using Proeficiencia.CrossCutting.Models;
using Proeficiencia.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Proeficiencia.Presentation
{
    public partial class ConsultaAlunos : Form
    {
        private readonly AlunoRepository _alunoRepository;

        public ConsultaAlunos()
        {
            InitializeComponent();

            _alunoRepository = new AlunoRepository(new Context());

            if (_alunoRepository == null) throw new ArgumentNullException($"Erro ao inicializar sistema. parametro: {nameof(_alunoRepository)}");
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private IEnumerable<Aluno> CarregarAlunoPorNome()
        {
            return _alunoRepository
                        .GetAll()
                        .Where(x => x.Nome.Contains(txtNome.Text));
        }

        private IEnumerable<Aluno> CarregarAlunoPorRa()
        {
            return _alunoRepository
                        .GetAll()
                        .Where(x => x.RA.Contains(txtRa.Text)); throw new Exception();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            using (var folder = new FolderBrowserDialog())
            {
                var dialogResult = folder.ShowDialog(this);

                if (dialogResult == DialogResult.OK)
                {
                    GerarRelatorio(folder.SelectedPath.ToString());

                    MessageBox.Show($"Arquivo baixado no diretorio selecionado: {folder.SelectedPath.ToString()}", "Aviso Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };



        }

        private void GerarRelatorio(string caminho)
        {
            using (var document = new PdfDocument())
            {
                var page = document.AddPage();
                var graphics = XGraphics.FromPdfPage(page);
                var textFormatter = new XTextFormatter(graphics);
                var font = new XFont("Calibri", 14);

                textFormatter.Alignment = XParagraphAlignment.Center;

                var listaAlunos = new List<Aluno>();

                if (rdbNome.Checked)
                {
                    listaAlunos = CarregarAlunoPorNome().ToList();
                }
                else
                {
                    listaAlunos = CarregarAlunoPorRa().ToList();
                }

                var iterador = 2;

                foreach (var item in listaAlunos)
                {
                    textFormatter.DrawString($"nome: {item.Nome} Ra: {item.RA}, Data Nascimento: {item.Nascimento.ToString("dd/MM/yyyy")} Curso: {item.Curso.ToString()}", font, XBrushes.Black, new XRect(iterador * 15, iterador * 30, page.Width - iterador * 30, page.Height - iterador * 30));
                    iterador++;
                }

                var path = $"{caminho}\\relatorioAlunos-{DateTime.Now.ToString("yyyyMMddmmss")}.pdf";

                document.Save(path);
                Process.Start(path);
            }
        }
    }
}