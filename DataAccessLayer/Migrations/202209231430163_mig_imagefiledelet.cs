namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_imagefiledelet : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ImageFiles", "ImagePath2");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ImageFiles", "ImagePath2", c => c.String(maxLength: 250));
        }
    }
}
