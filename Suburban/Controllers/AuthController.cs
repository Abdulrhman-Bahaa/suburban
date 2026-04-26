namespace Suburban.Controllers;

using Microsoft.AspNetCore.Mvc;
using Suburban.DTOs;
using Suburban.Services.Interfaces;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;
    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }


    [HttpPost("login")]
    public async Task<IActionResult> LoginAsync(LoginDto dto)
    {
        try
        {
            var token = await _authService.LoginAsync(new Services.Commands.LoginCommand
            {
                Email = dto.Email,
                Password = dto.Password
            });

            // Set token in HttpOnly cookie
            Response.Cookies.Append("jwt", token, new CookieOptions
            {
                HttpOnly = true,
                Secure = true,
                SameSite = SameSiteMode.Strict,
                Expires = DateTime.UtcNow.AddHours(1)
            });


            return Ok(new { Message = "Login successful" });
        }
        catch (InvalidOperationException ex)
        {
            return Unauthorized(new { Message = ex.Message });
        }
    }
}