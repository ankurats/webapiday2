namespace RestaurnatApiDemo.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RestaurnatApiDemo.Models.RestaurantApiContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RestaurnatApiDemo.Models.RestaurantApiContext context)
        {
            //List<Restaurant> list = new List<Restaurant>()
            //{
            //    new Restaurant {Id=1, Title="Mogli", City="Noida" },
            //    new Restaurant { Id = 2, Title = "YoChina", City = "Delhi"},
            //    new Restaurant { Id = 3, Title = "Haldiram", City = "Gurugram" }
            //};

            //context.Restaurants.AddOrUpdate(list.ToArray());
            //context.Reviews.AddOrUpdate(
            //    new Review {Id=1, Comment="Good Food", Reviewer="Ankit",Rating=5, Restaurant=list[1] },
            //     new Review { Id = 2, Comment = "Good service", Reviewer = "Monika",Rating=5,  Restaurant = list[1] }, 
            //     new Review { Id = 3, Comment = "Qulaity Food", Reviewer = "Riti", Rating = 5,  Restaurant = list[0] },
            //     new Review { Id = 4, Comment = "Nice Parking", Reviewer = "Mohit", Rating = 4, Restaurant = list[0] },
            //     new Review { Id = 5, Comment = "Fast Service", Reviewer = "Shalija", Rating = 5,  Restaurant = list[2] },
            //     new Review { Id = 6, Comment = "All good", Reviewer = "Sachin", Rating = 4, Restaurant = list[2] }

            //    );
            //context.SaveChanges();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
