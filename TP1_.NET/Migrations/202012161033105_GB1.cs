namespace TP1_.NET.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GB1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Title", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Title", c => c.String());
        }
    }
}
