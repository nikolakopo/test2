namespace CozySmart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class useradd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accommodations", "ApplicationUserId", c => c.Int(nullable: false));
            AddColumn("dbo.Accommodations", "ApplicationUser_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Accommodations", "ApplicationUser_Id");
            AddForeignKey("dbo.Accommodations", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Accommodations", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Accommodations", new[] { "ApplicationUser_Id" });
            DropColumn("dbo.Accommodations", "ApplicationUser_Id");
            DropColumn("dbo.Accommodations", "ApplicationUserId");
        }
    }
}
