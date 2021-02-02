namespace Prescriptions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clinics",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Address = c.String(maxLength: 255),
                        Mobile = c.String(maxLength: 20),
                        DoctorID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Doctors", t => t.DoctorID, cascadeDelete: false)
                .Index(t => t.DoctorID);
            
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.RXes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DoctorID = c.Int(nullable: false),
                        PationID = c.Int(nullable: false),
                        ClinicID = c.Int(nullable: false),
                        DateFrom = c.DateTime(nullable: false),
                        DateTo = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Clinics", t => t.ClinicID, cascadeDelete: false)
                .ForeignKey("dbo.Doctors", t => t.DoctorID, cascadeDelete: false)
                .ForeignKey("dbo.Pations", t => t.PationID, cascadeDelete: false)
                .Index(t => t.DoctorID)
                .Index(t => t.PationID)
                .Index(t => t.ClinicID);
            
            CreateTable(
                "dbo.Pations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 255),
                        Phone = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.RxDetails",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RXID = c.Int(nullable: false),
                        MedicineName = c.String(maxLength: 255),
                        Does = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.RXes", t => t.RXID, cascadeDelete: false)
                .Index(t => t.RXID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clinics", "DoctorID", "dbo.Doctors");
            DropForeignKey("dbo.RxDetails", "RXID", "dbo.RXes");
            DropForeignKey("dbo.RXes", "PationID", "dbo.Pations");
            DropForeignKey("dbo.RXes", "DoctorID", "dbo.Doctors");
            DropForeignKey("dbo.RXes", "ClinicID", "dbo.Clinics");
            DropIndex("dbo.RxDetails", new[] { "RXID" });
            DropIndex("dbo.RXes", new[] { "ClinicID" });
            DropIndex("dbo.RXes", new[] { "PationID" });
            DropIndex("dbo.RXes", new[] { "DoctorID" });
            DropIndex("dbo.Clinics", new[] { "DoctorID" });
            DropTable("dbo.RxDetails");
            DropTable("dbo.Pations");
            DropTable("dbo.RXes");
            DropTable("dbo.Doctors");
            DropTable("dbo.Clinics");
        }
    }
}
