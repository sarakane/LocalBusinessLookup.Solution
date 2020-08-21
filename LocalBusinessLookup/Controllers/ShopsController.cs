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
  public class ShopsController : ControllerBase
  {
    private LocalBusinessLookupContext _db;

    public ShopsController(LocalBusinessLookupContext db)
    {
      _db = db;
    }

    // GET api/Shops
    /// <summary>
    /// Gets all shops
    /// </summary>
    [HttpGet]
    public ActionResult<IEnumerable<Shop>> Get()
    {
      return _db.Shops.ToList();
    }

    // GET api/Shops/2
    /// <summary>
    /// Gets the shop with the specified id
    /// </summary>
    [HttpGet("{id}")]
    public ActionResult<Shop> Get(int id)
    {
      return _db.Shops.FirstOrDefault(entry => entry.ShopId == id);
    }

    // POST api/Shops
    /// <summary>
    /// Creates a shop
    /// </summary>
    [HttpPost]
    public void Post([FromBody] Shop shop)
    {
      _db.Shops.Add(shop);
      _db.SaveChanges();
    }

    // PUT api/Shops/2
    /// <summary>
    /// Edits the shop with the specified id
    /// </summary>
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Shop shop)
    {
      shop.ShopId = id;
      _db.Entry(shop).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/Shops/2
    /// <summary>
    /// Deletes the shop with the specified id
    /// </summary>
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var shopToDelete = _db.Shops.FirstOrDefault(entry => entry.ShopId == id);
      _db.Shops.Remove(shopToDelete);
      _db.SaveChanges();
    }
  }
}
