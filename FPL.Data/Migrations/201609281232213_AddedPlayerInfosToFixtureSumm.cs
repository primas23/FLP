namespace FPL.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPlayerInfosToFixtureSumm : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FixturesSummaries", "PlayerInformationId", "dbo.PlayerInformations");
            DropIndex("dbo.FixturesSummaries", new[] { "PlayerInformationId" });
            CreateTable(
                "dbo.FixturesSummaryPlayerInformations",
                c => new
                    {
                        FixturesSummary_Id = c.Int(nullable: false),
                        PlayerInformation_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.FixturesSummary_Id, t.PlayerInformation_Id })
                .ForeignKey("dbo.FixturesSummaries", t => t.FixturesSummary_Id, cascadeDelete: true)
                .ForeignKey("dbo.PlayerInformations", t => t.PlayerInformation_Id, cascadeDelete: true)
                .Index(t => t.FixturesSummary_Id)
                .Index(t => t.PlayerInformation_Id);
            
            DropColumn("dbo.FixturesSummaries", "PlayerInformationId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FixturesSummaries", "PlayerInformationId", c => c.Int(nullable: false));
            DropForeignKey("dbo.FixturesSummaryPlayerInformations", "PlayerInformation_Id", "dbo.PlayerInformations");
            DropForeignKey("dbo.FixturesSummaryPlayerInformations", "FixturesSummary_Id", "dbo.FixturesSummaries");
            DropIndex("dbo.FixturesSummaryPlayerInformations", new[] { "PlayerInformation_Id" });
            DropIndex("dbo.FixturesSummaryPlayerInformations", new[] { "FixturesSummary_Id" });
            DropTable("dbo.FixturesSummaryPlayerInformations");
            CreateIndex("dbo.FixturesSummaries", "PlayerInformationId");
            AddForeignKey("dbo.FixturesSummaries", "PlayerInformationId", "dbo.PlayerInformations", "Id", cascadeDelete: true);
        }
    }
}
