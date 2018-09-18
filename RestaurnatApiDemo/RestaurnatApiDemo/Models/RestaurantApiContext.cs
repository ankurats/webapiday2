using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestaurnatApiDemo.Models
{
    public class RestaurantApiContext : DbContext
    {
        public RestaurantApiContext()
            :base(@"server=lp-ankurp;uid=sa;pwd=info@123!;database=wepapidemo2")
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}