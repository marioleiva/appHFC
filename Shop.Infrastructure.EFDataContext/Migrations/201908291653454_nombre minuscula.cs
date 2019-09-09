namespace Shop.Infrastructure.EFDataContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nombreminuscula : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClaroTotalCanales", "nombreCanal", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClaroTotalCanales", "nombreCanal");
        }
    }
}
