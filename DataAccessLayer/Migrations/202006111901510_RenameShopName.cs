namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameShopName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Shops", "ShopName", c => c.String());
            DropColumn("dbo.Shops", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Shops", "Name", c => c.String());
            DropColumn("dbo.Shops", "ShopName");
        }
    }
}
