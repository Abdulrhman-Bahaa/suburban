using Suburban.Services.Interfaces;
using Suburban.Services;
using Suburban.Services.Commands;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Suburban.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class CartController : ControllerBase
{
    private readonly ICartService _cartService;

    public CartController(ICartService cartService)
    {
        _cartService = cartService;
    }


    [HttpPost("items")]
    public async Task<string> AddToCart([FromBody] AddToCardCommand command)
    {
        return await _cartService.AddToCart(command.UserId, command.ProductId, command.Quantity);
    }

    [HttpGet("items")]
    public async Task<string> GetCart()
    {
        return await _cartService.GetCart(User.FindFirst("sub")?.Value!);
    }
}