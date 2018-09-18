namespace RestaurnatApiDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Restaurants", "Country", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Restaurants", "Country");
        }
    }
}
