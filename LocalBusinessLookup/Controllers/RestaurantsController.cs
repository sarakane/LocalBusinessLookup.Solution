using LocalBusinessLookup.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBusinessLookup.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantsController : ControllerBase
    {
        private LocalBusinessLookupContext _db;

        public RestaurantsController(LocalBusinessLookupContext db)
        {
            _db = db;
        }

        // GET api/restaurants
        [HttpGet]
        public ActionResult<IEnumerable<Restaurant>> Get()
        {
            return _db.Restaurants.ToList();
        }

        // GET api/restaurants/2
        [HttpGet("{id}")]
        public ActionResult<Restaurant> Get(int id)
        {
            return _db.Restaurants.FirstOrDefault(entry => entry.RestaurantId == id);
        }

        // POST api/restaurants
        [HttpPost]
        public void Post([FromBody] Restaurant restaurant)
        {
            _db.Restaurants.Add(restaurant);
            _db.SaveChanges();
        }

        // PUT api/restaurants/2
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Restaurant  restaurant)
        {
            restaurant.RestaurantId = id;
            _db.Entry(restaurant).State = EntityState.Modified;
            _db.SaveChanges();
        }

        // DELETE api/restaurants/2
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var restaurantToDelete = _db.Restaurants.FirstOrDefault(entry => entry.RestaurantId == id);
            _db.Restaurants.Remove(restaurantToDelete);
            _db.SaveChanges();
        }
    }
}
