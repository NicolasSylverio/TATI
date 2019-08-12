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
            using (var login = new LoginRepository(new Context()))
            {
                var usuarioValido = login.GetByLogin(usuario);

                if (usuarioValido == null) return false;

                if (usuarioValido.Nome == usuario && usuarioValido.Senha == senha)
                {
                    Id = usuarioValido.Id;
                    Usuario = usuarioValido.Nome;
                    Tipo = usuarioValido.Tipo;

                    return true;
                }

                return false;
            }
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