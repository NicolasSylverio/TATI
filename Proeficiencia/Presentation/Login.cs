using Proeficiencia.Domain;
using System;
using System.Windows.Forms;

namespace Proeficiencia.Presentation
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var resultado = Logon.ValidarUsuario(txtLogin.Text, txtSenha.Text);

                if (resultado)
                {
                    var form = new Menu();

                    form.Show();
                    Close(); 
                }

                MessageBox.Show($"Usuario ou Senha Inválidos.", "Aviso Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro Fatal: {ex}", "Aviso Sistema");
                Application.Exit();
            }
        }
    }
}
