namespace Shop.Infrastructure.EFDataContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClaroCanales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Plan = c.String(),
                        HD = c.Int(nullable: false),
                        SD = c.Int(nullable: false),
                        Audio = c.Int(nullable: false),
                        Total = c.Int(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ClaroCanalesPlus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Plan = c.String(),
                        HD = c.Int(nullable: false),
                        SD = c.Int(nullable: false),
                        Total = c.Int(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ClaroTotalCanales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TECNOLOGIA = c.String(),
                        DEFINICION = c.String(),
                        GENERO = c.String(),
                        NUMERO_CANAL = c.Int(nullable: false),
                        NUMERO_CANAL2 = c.Int(nullable: false),
                        OBSERVACIONES = c.String(),
                        NOMBRE_CANAL = c.String(),
                        Claro_HDTV_Basico = c.String(),
                        Claro_HDTV_Avanzado = c.String(),
                        Claro_HDTV_Superior = c.String(),
                        Paquete_HBO = c.String(),
                        Paquete_Fox_Premium = c.String(),
                        Canal_NHK = c.String(),
                        HotPack_HD = c.String(),
                        ADRENALINA_SPORTS_NETWORK = c.String(),
                        Golden_Premier = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Descripcion = c.String(),
                        CategoryId = c.Int(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Employes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Birthday = c.String(),
                        Address = c.String(),
                        Sex = c.Int(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SalesTurns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Start = c.DateTime(nullable: false),
                        End = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SalesTurnEmployes",
                c => new
                    {
                        SalesTurn_Id = c.Int(nullable: false),
                        Employe_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SalesTurn_Id, t.Employe_Id })
                .ForeignKey("dbo.SalesTurns", t => t.SalesTurn_Id, cascadeDelete: true)
                .ForeignKey("dbo.Employes", t => t.Employe_Id, cascadeDelete: true)
                .Index(t => t.SalesTurn_Id)
                .Index(t => t.Employe_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SalesTurnEmployes", "Employe_Id", "dbo.Employes");
            DropForeignKey("dbo.SalesTurnEmployes", "SalesTurn_Id", "dbo.SalesTurns");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropIndex("dbo.SalesTurnEmployes", new[] { "Employe_Id" });
            DropIndex("dbo.SalesTurnEmployes", new[] { "SalesTurn_Id" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropTable("dbo.SalesTurnEmployes");
            DropTable("dbo.SalesTurns");
            DropTable("dbo.Employes");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
            DropTable("dbo.ClaroTotalCanales");
            DropTable("dbo.ClaroCanalesPlus");
            DropTable("dbo.ClaroCanales");
        }
    }
}
