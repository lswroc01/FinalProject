namespace GamesVille.Migrations
{
    using GamesVille.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GamesVille.Models.GameDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "GamesVille.Models.GameDBContext";
        }

        protected override void Seed(GamesVille.Models.GameDBContext context)
        {
            context.Games.AddOrUpdate(i => i.Title,
                new Game
                {
                    Title = "Wolfenstein: The New Order",
                    ReleaseDate = DateTime.Parse("5/20/2014"),
                    Platform = "PS3",
                    ESBR_Rating = "M",
                    Category = "Shooter",
                    Rating = 4.5m,
                    PictureURL = "http://cdn4.spong.com/pack/w/o/wolfenstei408079l/_-Wolfenstein-The-New-Order-PS3-_.jpg",


                });
        }
    }
}
