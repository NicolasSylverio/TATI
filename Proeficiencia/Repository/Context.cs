using Proeficiencia.CrossCutting.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Proeficiencia.Repository
{
    public class Context : DbContext
    {
        public Context() : base("Context")
        {
        }

        public DbSet<Aluno> Aluno { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}