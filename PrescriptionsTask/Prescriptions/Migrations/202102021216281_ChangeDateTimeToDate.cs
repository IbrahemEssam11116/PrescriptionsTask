namespace Prescriptions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDateTimeToDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Doctors", "Specialty", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Doctors", "Specialty");
        }
    }
}
