using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using Proeficiencia.CrossCutting.Constants;
using Proeficiencia.CrossCutting.Models;
using Proeficiencia.Domain;
using Proeficiencia.Repository;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Proeficiencia.Presentation
{
    public partial class IncluirArquivo : Form
    {
        private readonly ControleDocumentoRepository _controleDocumentoRepository;

        public IncluirArquivo()
        {
            InitializeComponent();

            _controleDocumentoRepository = new ControleDocumentoRepository(new Context());

            if (_controleDocumentoRepository == null) throw new ArgumentNullException($"Erro ao inicializar sistema. parametro: {nameof(_controleDocumentoRepository)}");
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnProcurar_Click(object sender, EventArgs e)
        {
            using (var fileDialog = new OpenFileDialog())
            {
                fileDialog.InitialDirectory = @"C:\Users";
                fileDialog.Filter = "txt files|*.txt;*.docx|csv files|*.csv;*.xlsx|pdf files|*.pdf|Images files|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|All files (*.*)|*.*";

                var file = fileDialog.ShowDialog(this);

                if (file == DialogResult.OK && File.Exists(fileDialog.FileName))
                {
                    txtArquivo.Text = fileDialog.FileName;
                }
            };
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtArquivo.Text))
                {
                    var arquivoSistema = Directory.GetCurrentDirectory();

                    if (arquivoSistema.IndexOf(Constants.SistemDebugPath) != 0)
                    {
                        arquivoSistema = arquivoSistema.Replace(Constants.SistemDebugPath, Constants.SistemFileSendPath);
                    }
                    else if (arquivoSistema.IndexOf(Constants.SistemReleasePath) != 0)
                    {
                        arquivoSistema = arquivoSistema.Replace(Constants.SistemReleasePath, Constants.SistemFileSendPath);
                    }
                    else
                    {
                        throw new Exception("Caminho do Arquivo do sistema não especificado.");
                    }

                    var fileNameArray = txtArquivo.Text.Split('\\');

                    var fileName = fileNameArray[fileNameArray.Length - 1];

                    var fileNameWithPath = arquivoSistema + "\\" + fileName;

                    if (File.Exists(fileNameWithPath))
                    {
                        throw new Exception($"Nome do Arquivo já Existente na Base ou Arquivo já Enviado. Altere o nome e verifique se este ja não foi enviado. Nome Arquivo: {fileName}");
                    }

                    var controle = new ControleDocumento
                    {
                        NomeDocumento = fileName,
                        IdUsuarioEnvio = Logon.Id,
                        DataEnvio = DateTime.Now,
                        CaminhoArquivo = fileNameWithPath,
                        Erro = false,
                        DataValidacao = null
                    };

                    _controleDocumentoRepository.Add(controle);

                    File.Copy(txtArquivo.Text, fileNameWithPath);
                    
                    MessageBox.Show($"Arquivo Enviado com Sucesso. Arquivo : {fileName}", "Aviso Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GerarRelatorio(fileName, txtArquivo.Text.Replace(fileName, ""));

                    txtArquivo.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro do Sistema {ex.Message}", "Aviso Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GerarRelatorio(string fileName, string caminho)
        {
            using (var document = new PdfDocument())
            {
                var page = document.AddPage();
                var graphics = XGraphics.FromPdfPage(page);
                var textFormatter = new XTextFormatter(graphics);
                var font = new XFont("Calibri", 14);

                textFormatter.Alignment = XParagraphAlignment.Center;
                textFormatter.DrawString($"Arquivo Enviado Com Sucesso: {fileName} Login: {Logon.Usuario}, Data: {DateTime.Now.ToString("dd/MM/yyyy mm:ss")}", font, XBrushes.Black, new XRect(30, 60, page.Width - 60, page.Height - 60));

                var path = $"{caminho}\\relatorio{DateTime.Now.ToString("yyyyMMddmmss")}.pdf";

                document.Save(path);
                Process.Start(path);
            }
        }
    }
}