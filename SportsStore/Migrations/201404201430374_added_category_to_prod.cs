namespace SportsStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_category_to_prod : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Category", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Category");
        }
    }
}
