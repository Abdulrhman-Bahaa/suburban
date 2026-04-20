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
            return Ok(new { Token = token });
        }
        catch (InvalidOperationException ex)
        {
            return Unauthorized(new { Message = ex.Message });
        }
    }
}