
using Suburban.Data;
using Suburban.Models;
using StackExchange.Redis;
using Suburban.Repositories.Interfaces;

class CartRepository : ICartRepository
{
    private readonly IDatabase _db;

    public CartRepository(IConnectionMultiplexer redis)
    {
        _db = redis.GetDatabase();
    }

    public async Task<string> AddToCart(string userId, string productId, int quantity)
    {
        var cartKey = $"cart:{userId}";
        await _db.HashSetAsync(cartKey, productId, quantity);
        return "Product added to cart";
    }

    public async Task<string> GetCart(string userId)
    {
        var cartKey = $"cart:{userId}";
        var entries = await _db.HashGetAllAsync(cartKey);
        if (entries.Length == 0)
        {
            return "Cart is empty";
        }

        var cartItems = entries.Select(entry => new Cart
        {
            ProductId = entry.Name,
            Quantity = (int)entry.Value
        }).ToList();

        return System.Text.Json.JsonSerializer.Serialize(cartItems);
    }
}