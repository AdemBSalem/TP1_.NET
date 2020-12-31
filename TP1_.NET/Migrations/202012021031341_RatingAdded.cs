namespace TP1_.NET.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RatingAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Rating", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Rating");
        }
    }
}
