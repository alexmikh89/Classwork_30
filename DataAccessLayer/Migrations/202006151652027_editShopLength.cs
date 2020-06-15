namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editShopLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Shops", "ShopName", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Shops", "ShopName", c => c.String());
        }
    }
}
