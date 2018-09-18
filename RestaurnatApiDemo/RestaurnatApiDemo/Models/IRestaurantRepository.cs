using System.Collections.Generic;

namespace RestaurnatApiDemo.Models
{
    public interface IRestaurantRepository
    {
        List<Restaurant> GetAllRestaurant();
        Restaurant GetRestaurantById(int id);
    }
}