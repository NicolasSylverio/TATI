namespace Proeficiencia.Migrations
{
    using Proeficiencia.CrossCutting.Models;
    using Proeficiencia.Repository;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Context context)
        {
            context.Set<Login>().AddOrUpdate(new Login
            {
                Nome = "master",
                Senha = "1234",
                Tipo = 1
            });

            context.Set<Login>().AddOrUpdate(new Login
            {
                Nome = "usuario",
                Senha = "1234",
                Tipo = 0
            });
        }
    }
}