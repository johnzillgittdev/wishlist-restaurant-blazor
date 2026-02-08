using RestaurantWishlist.Tables;

namespace RestaurantWishlist.Repository;

public class LocalRestaurantRepository : IRestaurantRepository
{
    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Restaurant>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task SaveAsync(Restaurant restaurant)
    {
        throw new NotImplementedException();
    }
}
