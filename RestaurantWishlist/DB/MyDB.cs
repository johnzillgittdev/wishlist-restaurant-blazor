using BlazorDexie.Database;
using BlazorDexie.Options;
using RestaurantWishlist.Tables;

namespace RestaurantWishlist.DB;

public class MyDB : Db<MyDB>
{
    public Store<Restaurant, Guid> Restaurants { get; private set; } = new("id", "name", "*cuisines", "lastModified");

    public MyDB(BlazorDexieOptions options) : base("WishlistDatabase", 3, new IDbVersion[] { }, options)
    {
        
    }
}
