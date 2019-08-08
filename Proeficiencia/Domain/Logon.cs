using Proeficiencia.Repository;

namespace Proeficiencia.Domain
{
    public static class Logon
    {
        public static int Id { get; private set; }
        public static string Usuario { get; private set; }
        public static int Tipo { get; private set; }

        public static bool ValidarUsuario(string usuario, string senha)
        {
            var login = new LoginRepository(new Context());

            var usuarioValido = login.GetByLogin(usuario);

            login.Dispose();

            if (usuarioValido.Nome == usuario && usuarioValido.Senha == senha)
            {
                Id = 0;
                Usuario = usuario;
                Tipo = 1;

                return true;
            }

            return false;
        }

        public static bool UsuarioLogado()
        {
            if (Id > 0)
            {
                return true;
            }

            return false;
        }
    }
}