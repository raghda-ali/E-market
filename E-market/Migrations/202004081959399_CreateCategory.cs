namespace E_market.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateCategory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        number_of_products = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.Products", "category_id1", c => c.Int());
            CreateIndex("dbo.Products", "category_id1");
            AddForeignKey("dbo.Products", "category_id1", "dbo.Categories", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "category_id1", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "category_id1" });
            DropColumn("dbo.Products", "category_id1");
            DropTable("dbo.Categories");
        }
    }
}
