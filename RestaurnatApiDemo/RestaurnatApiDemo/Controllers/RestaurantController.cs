using CacheCow.Server.WebApi;
using RestaurnatApiDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestaurnatApiDemo.Controllers
{
    public class RestaurantController : ApiController
    {
        IRestaurantRepository _repo;
        public RestaurantController(IRestaurantRepository repo)
        {
            _repo = repo;
        }
       
        
        public List<Restaurant> Get()
        {
            return _repo.GetAllRestaurant();
        }
        [HttpCache]
        public IHttpActionResult Get(int id)
        {
            var res = _repo.GetRestaurantById(id);
            if (res != null)
                return Ok<Restaurant>(res);
            else
                return NotFound();
        }
    }
}
