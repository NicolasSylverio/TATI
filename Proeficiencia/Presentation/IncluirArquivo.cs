using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proeficiencia.Presentation
{
    public partial class IncluirArquivo : Form
    {
        public IncluirArquivo()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog();

            var file = fileDialog.ShowDialog(this);
        }
    }
}
