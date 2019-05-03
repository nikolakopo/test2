namespace CozySmart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ele : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Elementsforbookings", "AccommodationId", "dbo.Accommodations");
            DropIndex("dbo.Elementsforbookings", new[] { "AccommodationId" });
            DropTable("dbo.Elementsforbookings");
        }
        
        public override void Down()
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
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Elementsforbookings", "AccommodationId");
            AddForeignKey("dbo.Elementsforbookings", "AccommodationId", "dbo.Accommodations", "Id", cascadeDelete: true);
        }
    }
}
