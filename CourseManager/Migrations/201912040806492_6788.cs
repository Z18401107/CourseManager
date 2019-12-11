namespace CourseManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _6788 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Classes", "Name", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Classes", "Name", c => c.String(maxLength: 50));
        }
    }
}
