namespace GamesVille.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "PictureURL", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "PictureURL");
        }
    }
}
