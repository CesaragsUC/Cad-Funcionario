namespace CadFuncionario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alteracao : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departamento",
                c => new
                    {
                        DepartamentoID = c.Int(nullable: false, identity: true),
                        DEPARTAMENTO_NOME = c.String(),
                        DEPARTAMENTO_SALA = c.String(),
                        ANDAR = c.String(),
                    })
                .PrimaryKey(t => t.DepartamentoID);
            
            CreateTable(
                "dbo.Funcionario",
                c => new
                    {
                        FuncionarioID = c.Int(nullable: false, identity: true),
                        FUNCIONARIO_EMAIL = c.String(),
                        FUNCIONARIO_NOME = c.String(),
                        FUNCIONARIO_CIDADE = c.String(),
                        FUNCIONARIO_ENDERECO = c.String(),
                        FUNCIONARIO_CPF = c.String(),
                        FUNCIONARIO_TELEFONE = c.String(),
                        DepartamentoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FuncionarioID)
                .ForeignKey("dbo.Departamento", t => t.DepartamentoID, cascadeDelete: true)
                .Index(t => t.DepartamentoID);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        UsuarioID = c.Int(nullable: false, identity: true),
                        USER_NAME = c.String(),
                        USER_SENHA = c.String(),
                        PERFIL = c.String(),
                        ATIVO = c.String(),
                    })
                .PrimaryKey(t => t.UsuarioID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Funcionario", "DepartamentoID", "dbo.Departamento");
            DropIndex("dbo.Funcionario", new[] { "DepartamentoID" });
            DropTable("dbo.Usuario");
            DropTable("dbo.Funcionario");
            DropTable("dbo.Departamento");
        }
    }
}
