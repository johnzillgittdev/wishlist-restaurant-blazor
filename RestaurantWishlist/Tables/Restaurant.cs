using RestaurantWishlist.Enums;

namespace RestaurantWishlist.Tables;

public class Restaurant
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<Cuisine> Cuisines { get; set; }
    public DateTime LastModified { get; set; }

    public Restaurant(string name, List<Cuisine> cuisines)
    {
        Id = Guid.NewGuid();
        Name = name;
        Cuisines = cuisines;
        LastModified = DateTime.UtcNow;
    }

    public Restaurant()
    {
        Name = string.Empty;
        Cuisines = new List<Cuisine>();
    }
}
