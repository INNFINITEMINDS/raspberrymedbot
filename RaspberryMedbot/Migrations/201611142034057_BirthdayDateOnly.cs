namespace RaspberryMedbot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BirthdayDateOnly : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Activities",
                c => new
                    {
                        ActivityID = c.Int(nullable: false, identity: true),
                        PatientID = c.Int(nullable: false),
                        Response = c.Boolean(),
                        CreationTime = c.DateTime(nullable: false),
                        ResponseTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.ActivityID)
                .ForeignKey("dbo.Patients", t => t.PatientID, cascadeDelete: true)
                .Index(t => t.PatientID);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        PatientID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Birthday = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PatientID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Activities", "PatientID", "dbo.Patients");
            DropIndex("dbo.Activities", new[] { "PatientID" });
            DropTable("dbo.Patients");
            DropTable("dbo.Activities");
        }
    }
}
