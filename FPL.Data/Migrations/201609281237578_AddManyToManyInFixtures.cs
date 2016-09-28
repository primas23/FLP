namespace FPL.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddManyToManyInFixtures : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Fixtures", "PlayerInformationId", "dbo.PlayerInformations");
            DropIndex("dbo.Fixtures", new[] { "PlayerInformationId" });
            CreateTable(
                "dbo.FixturePlayerInformations",
                c => new
                    {
                        Fixture_Id = c.Int(nullable: false),
                        PlayerInformation_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Fixture_Id, t.PlayerInformation_Id })
                .ForeignKey("dbo.Fixtures", t => t.Fixture_Id, cascadeDelete: true)
                .ForeignKey("dbo.PlayerInformations", t => t.PlayerInformation_Id, cascadeDelete: true)
                .Index(t => t.Fixture_Id)
                .Index(t => t.PlayerInformation_Id);
            
            DropColumn("dbo.Fixtures", "PlayerInformationId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Fixtures", "PlayerInformationId", c => c.Int(nullable: false));
            DropForeignKey("dbo.FixturePlayerInformations", "PlayerInformation_Id", "dbo.PlayerInformations");
            DropForeignKey("dbo.FixturePlayerInformations", "Fixture_Id", "dbo.Fixtures");
            DropIndex("dbo.FixturePlayerInformations", new[] { "PlayerInformation_Id" });
            DropIndex("dbo.FixturePlayerInformations", new[] { "Fixture_Id" });
            DropTable("dbo.FixturePlayerInformations");
            CreateIndex("dbo.Fixtures", "PlayerInformationId");
            AddForeignKey("dbo.Fixtures", "PlayerInformationId", "dbo.PlayerInformations", "Id", cascadeDelete: true);
        }
    }
}
