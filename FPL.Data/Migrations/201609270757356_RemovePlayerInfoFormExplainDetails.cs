namespace FPL.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovePlayerInfoFormExplainDetails : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ExplainDetails", "PlayerInformationId", "dbo.PlayerInformations");
            DropIndex("dbo.ExplainDetails", new[] { "PlayerInformationId" });
            DropColumn("dbo.ExplainDetails", "PlayerInformationId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ExplainDetails", "PlayerInformationId", c => c.Int(nullable: false));
            CreateIndex("dbo.ExplainDetails", "PlayerInformationId");
            AddForeignKey("dbo.ExplainDetails", "PlayerInformationId", "dbo.PlayerInformations", "Id", cascadeDelete: true);
        }
    }
}
