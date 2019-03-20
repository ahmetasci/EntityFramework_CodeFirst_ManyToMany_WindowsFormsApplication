namespace CodeFirst2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Egitmen",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Soyad = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Ogrenci",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Soyad = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.OgrenciEgitmen",
                c => new
                    {
                        Ogrenci_ID = c.Int(nullable: false),
                        Egitmen_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Ogrenci_ID, t.Egitmen_ID })
                .ForeignKey("dbo.Ogrenci", t => t.Ogrenci_ID, cascadeDelete: true)
                .ForeignKey("dbo.Egitmen", t => t.Egitmen_ID, cascadeDelete: true)
                .Index(t => t.Ogrenci_ID)
                .Index(t => t.Egitmen_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OgrenciEgitmen", "Egitmen_ID", "dbo.Egitmen");
            DropForeignKey("dbo.OgrenciEgitmen", "Ogrenci_ID", "dbo.Ogrenci");
            DropIndex("dbo.OgrenciEgitmen", new[] { "Egitmen_ID" });
            DropIndex("dbo.OgrenciEgitmen", new[] { "Ogrenci_ID" });
            DropTable("dbo.OgrenciEgitmen");
            DropTable("dbo.Ogrenci");
            DropTable("dbo.Egitmen");
        }
    }
}
