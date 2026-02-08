using RestaurantWishlist.Enums;

namespace RestaurantWishlist.Tables;

public class Restaurant
{
    public Guid ID { get; set; }
    public string Name { get; set; }
    public Cuisine Cuisine { get; set; }
    public DateTime LastModified { get; set; }

    public Restaurant(string name, Cuisine cuisine)
    {
        ID = Guid.NewGuid();
        Name = name;
        Cuisine = cuisine;
        LastModified = DateTime.UtcNow;
    }
}
