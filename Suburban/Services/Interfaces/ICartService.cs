namespace Suburban.Services.Interfaces;

public interface ICartService
{
    public Task<string> AddToCart(string userId, string productId, int quantity);
    public Task<string> GetCart(string userId);
}