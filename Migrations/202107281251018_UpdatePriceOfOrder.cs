namespace demo_02.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePriceOfOrder : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.OrderDetails", "Price", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OrderDetails", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
