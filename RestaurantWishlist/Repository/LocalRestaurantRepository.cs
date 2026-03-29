using BlazorDexie.Options;
using Microsoft.AspNetCore.Components;
using RestaurantWishlist.DB;
using RestaurantWishlist.Tables;

namespace RestaurantWishlist.Repository;

public class LocalRestaurantRepository : IRestaurantRepository
{
    private MyDB _db;

    public LocalRestaurantRepository(MyDB db)
    {
        _db = db;
    }

    public async Task DeleteAsync(Guid id)
    {
        await _db.Restaurants.Delete(id);
    }

    public async Task<List<Restaurant>> GetAllAsync()
    {
        return await _db.Restaurants.ToList();
    }

    public async Task SaveAsync(Restaurant restaurant)
    {
        await _db.Restaurants.Put(restaurant);
    }
}
