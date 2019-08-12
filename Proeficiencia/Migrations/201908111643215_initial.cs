namespace Proeficiencia.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aluno",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Nome = c.String(nullable: false, maxLength: 80),
                    RA = c.String(nullable: false, maxLength: 16),
                    Nascimento = c.DateTime(nullable: false),
                    Curso = c.Int(nullable: false),
                    Matriculado = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.ControleDocumento",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    NomeDocumento = c.String(nullable: false, maxLength: 100),
                    CaminhoArquivo = c.String(nullable: false),
                    DataEnvio = c.DateTime(nullable: false),
                    DataValidacao = c.DateTime(),
                    IdUsuarioEnvio = c.Int(nullable: false),
                    IdUsuarioValidador = c.Int(nullable: false),
                    MensagemControle = c.String(maxLength: 512),
                    Erro = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Login",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Nome = c.String(nullable: false, maxLength: 16),
                    Senha = c.String(nullable: false, maxLength: 16),
                    Tipo = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id);

        }

        public override void Down()
        {
            DropTable("dbo.Login");
            DropTable("dbo.ControleDocumento");
            DropTable("dbo.Aluno");
        }
    }
}
