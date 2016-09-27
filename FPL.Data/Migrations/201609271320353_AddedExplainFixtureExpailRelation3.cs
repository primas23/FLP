namespace FPL.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedExplainFixtureExpailRelation3 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.ExplainFixtures", "FantasyPremierLeagueId", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.ExplainFixtures", new[] { "FantasyPremierLeagueId" });
        }
    }
}
