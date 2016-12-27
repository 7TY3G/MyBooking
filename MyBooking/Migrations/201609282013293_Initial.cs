namespace MyBooking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookingModels",
                c => new
                    {
                        BookingId = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(),
                        StaffId = c.Int(nullable: false),
                        BookingDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BookingId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BookingModels");
        }
    }
}
