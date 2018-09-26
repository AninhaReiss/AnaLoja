namespace AnaLoja.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class criarSPs : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.Produto",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            Descricao = c.String(),
            //            Categoria = c.String(),
            //            Preco = c.Decimal(nullable: false, precision: 18, scale: 2),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            CreateStoredProcedure(
                "dbo.Produto_Insert",
                p => new
                    {
                        Descricao = p.String(),
                        Categoria = p.String(),
                        Preco = p.Decimal(precision: 18, scale: 2),
                    },
                body:
                    @"INSERT [dbo].[Produto]([Descricao], [Categoria], [Preco])
                      VALUES (@Descricao, @Categoria, @Preco)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Produto]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[Produto] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.Produto_Update",
                p => new
                    {
                        Id = p.Int(),
                        Descricao = p.String(),
                        Categoria = p.String(),
                        Preco = p.Decimal(precision: 18, scale: 2),
                    },
                body:
                    @"UPDATE [dbo].[Produto]
                      SET [Descricao] = @Descricao, [Categoria] = @Categoria, [Preco] = @Preco
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.Produto_Delete",
                p => new
                    {
                        Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Produto]
                      WHERE ([Id] = @Id)"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.Produto_Delete");
            DropStoredProcedure("dbo.Produto_Update");
            DropStoredProcedure("dbo.Produto_Insert");
            DropTable("dbo.Produto");
        }
    }
}
