namespace Shop.Infrastructure.EFDataContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Genero : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Generoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GeneroCanal = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Generoes");
        }
    }
}
