using Suburban.Repositories.Interfaces;
using Suburban.Services.Interfaces;
using Suburban.Models;

namespace Suburban.Services;

public class CartService : ICartService
{
    private readonly ICartRepository _cartRepository;
    public CartService(ICartRepository cartRepository)
    {
        _cartRepository = cartRepository;
    }

    public async Task<string> AddToCart(string userId, string productId, int quantity)
    {
        return await _cartRepository.AddToCart(userId, productId, quantity);
    }

    public async Task<string> GetCart(string userId)
    {
        return await _cartRepository.GetCart(userId);
    }
}