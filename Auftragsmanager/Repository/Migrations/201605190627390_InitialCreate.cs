namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adress",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Street = c.String(),
                        City = c.String(),
                        Country = c.String(),
                        POBox = c.String(),
                        ZIP = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ContactPerson",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Telefon = c.String(),
                        Fax = c.String(),
                        Mail = c.String(),
                        adress_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Adress", t => t.adress_Id)
                .Index(t => t.adress_Id);
            
            CreateTable(
                "dbo.CustomerObject",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EdvActions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Machine",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        UsageStart = c.DateTime(nullable: false),
                        UsageEnd = c.DateTime(nullable: false),
                        EdvActions_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EdvActions", t => t.EdvActions_Id)
                .Index(t => t.EdvActions_Id);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        LastName = c.String(),
                        Username = c.String(),
                        AccessLevel = c.Int(nullable: false),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Machine", "EdvActions_Id", "dbo.EdvActions");
            DropForeignKey("dbo.ContactPerson", "adress_Id", "dbo.Adress");
            DropIndex("dbo.Machine", new[] { "EdvActions_Id" });
            DropIndex("dbo.ContactPerson", new[] { "adress_Id" });
            DropTable("dbo.User");
            DropTable("dbo.Order");
            DropTable("dbo.Machine");
            DropTable("dbo.EdvActions");
            DropTable("dbo.Customer");
            DropTable("dbo.CustomerObject");
            DropTable("dbo.ContactPerson");
            DropTable("dbo.Adress");
        }
    }
}
