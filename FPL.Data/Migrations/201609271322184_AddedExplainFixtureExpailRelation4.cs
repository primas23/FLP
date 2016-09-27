namespace FPL.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedExplainFixtureExpailRelation4 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.ExplainFixtures", new[] { "FantasyPremierLeagueId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.ExplainFixtures", "FantasyPremierLeagueId", unique: true);
        }
    }
}
