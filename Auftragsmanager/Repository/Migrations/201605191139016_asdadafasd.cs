namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asdadafasd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Utilities",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Utilities");
        }
    }
}
