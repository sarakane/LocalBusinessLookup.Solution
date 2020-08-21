using System.ComponentModel.DataAnnotations;

namespace LocalBusinessLookup.Models
{
  public class Restaurant
  {
    public int RestaurantId { get; set; }
    [Required]
    [StringLength(50)]
    public string Name { get; set; }
    [Required]
    [StringLength(50)]
    public string Cuisine {get; set; }
    [Phone]
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
  }
}