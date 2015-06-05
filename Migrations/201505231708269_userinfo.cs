namespace ASP.NET_MVC5_Bootstrap_3._3._4_LESS1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userinfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "BirthDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "BirthDate");
        }
    }
}
