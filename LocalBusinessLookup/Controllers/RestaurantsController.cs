using LocalBusinessLookup.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LocalBusinessLookup.Controllers
{
  [Produces("application/json")]
  [Route("api/[controller]")]
  [ApiController]
  public class RestaurantsController : ControllerBase
  {
    private LocalBusinessLookupContext _db;

    public RestaurantsController(LocalBusinessLookupContext db)
    {
      _db = db;
    }

    /// <summary>
    /// Gets all restaurants
    /// </summary>
    [HttpGet]
    public ActionResult<IEnumerable<Restaurant>> Get()
    {
      return _db.Restaurants.ToList();
    }

    // GET api/restaurants/2
    /// <summary>
    /// Gets a restaurant with the specified id
    /// </summary>
    [HttpGet("{id}")]
    public ActionResult<Restaurant> Get(int id)
    {
      return _db.Restaurants.FirstOrDefault(entry => entry.RestaurantId == id);
    }

    /// <summary>
    /// Creates a restaurant
    /// </summary>
    /// <remarks>
    /// Sample request:
    ///
    ///     POST /Resaurants
    ///     {
    ///      "Name": "Restaurant name",
    ///      "Cuisine": "Cuisine type",
    ///      "PhoneNumber": "555-555-5555",
    ///      "Address": "123 Street St",
    ///      "City": "City",
    ///      "State": "OR"
    ///    }
    /// </remarks>
    /// <param name="restaurant"></param>
    /// <returns>A newly created restaurant</returns>
    [HttpPost]
    public void Post([FromBody] Restaurant restaurant)
    {
      _db.Restaurants.Add(restaurant);
      _db.SaveChanges();
    }

    // PUT api/restaurants/2
    /// <summary>
    /// Edits the restaurant with the specified id
    /// </summary>
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Restaurant restaurant)
    {
      restaurant.RestaurantId = id;
      _db.Entry(restaurant).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/restaurants/2
    /// <summary>
    /// Deletes the restaurant with the specified id
    /// </summary>
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var restaurantToDelete = _db.Restaurants.FirstOrDefault(entry => entry.RestaurantId == id);
      _db.Restaurants.Remove(restaurantToDelete);
      _db.SaveChanges();
    }
  }
}
