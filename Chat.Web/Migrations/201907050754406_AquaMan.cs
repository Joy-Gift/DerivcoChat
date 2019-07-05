namespace Chat.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AquaMan : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "IsAdmin", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Messages", "IsAdmin");
        }
    }
}
