namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_imagefiletwo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ImageFiles", "ImagePath2", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ImageFiles", "ImagePath2");
        }
    }
}
