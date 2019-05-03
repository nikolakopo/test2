namespace CozySmart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class elements : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Elementsforbookings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccommodationId = c.Int(nullable: false),
                        Arrival = c.DateTime(nullable: false),
                        Departure = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accommodations", t => t.AccommodationId, cascadeDelete: true)
                .Index(t => t.AccommodationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Elementsforbookings", "AccommodationId", "dbo.Accommodations");
            DropIndex("dbo.Elementsforbookings", new[] { "AccommodationId" });
            DropTable("dbo.Elementsforbookings");
        }
    }
}
