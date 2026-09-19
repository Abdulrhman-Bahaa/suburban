namespace Suburban.Repositories.Interfaces;

using Suburban.Models;

public interface ICartRepository
{
    public Task<string> AddToCart(string userId, string productId, int quantity);

    public Task<string> GetCart(string userId);

};