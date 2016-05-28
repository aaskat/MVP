namespace Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAmount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Amount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Amount");
        }
    }
}
