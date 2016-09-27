namespace FPL.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedModelBaseToPlayerInfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PlayerInformations", "CreatedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.PlayerInformations", "IsDeleted", c => c.Boolean(nullable: false));
            CreateIndex("dbo.PlayerInformations", "IsDeleted");
        }
        
        public override void Down()
        {
            DropIndex("dbo.PlayerInformations", new[] { "IsDeleted" });
            DropColumn("dbo.PlayerInformations", "IsDeleted");
            DropColumn("dbo.PlayerInformations", "CreatedOn");
        }
    }
}
