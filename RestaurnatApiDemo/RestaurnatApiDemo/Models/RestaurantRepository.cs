using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurnatApiDemo.Models
{
    public class RestaurantRepository : IRestaurantRepository
    {
        private RestaurantApiContext _db;
        public RestaurantRepository(RestaurantApiContext db)
        {
            _db = db;
        }
        public List<Restaurant> GetAllRestaurant()
        {
           return  _db.Restaurants.ToList();
        }

        public Restaurant GetRestaurantById(int id)
        {
            return _db.Restaurants.ToList().Find(x => x.Id == id);
        }
    }
}