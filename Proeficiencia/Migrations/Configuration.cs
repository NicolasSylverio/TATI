namespace Proeficiencia.Migrations
{
    using CrossCutting.Models;
    using Repository;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Context context)
        {
            context.Login.Add(new Login { Nome = "master", Senha = "1234", Tipo = 1 });

            context.Login.Add(new Login { Nome = "usuario", Senha = "1234", Tipo = 0 });

            context.SaveChanges();
        }
    }
}