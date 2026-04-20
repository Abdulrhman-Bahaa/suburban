using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Suburban.DTOs;
using Suburban.Models;
using Suburban.Services.Commands;

namespace Suburban.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly Services.Interfaces.IUserService _userService;

    public UsersController(Services.Interfaces.IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost]
    public async Task<ActionResult<UserDto>> CreateUser(CreateUserDto dto)
    {
        try
        {
            var command = new CreateUserCommand
            {
                Name = dto.Name,
                Email = dto.Email,
                Password = dto.Password
            };

            var user = await _userService.CreateUserAsync(command);
            return Ok(user);
        }
        catch (InvalidOperationException ex)
        {
            return Conflict(new { message = ex.Message });
        }
    }

    [Authorize]
    [HttpGet("me")]
    public async Task<UserDto> Me()
    {
        var userId = User.Claims.FirstOrDefault(c => c.Type == System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
        if (userId == null)
        {
            throw new InvalidOperationException("User ID claim not found.");
        }

        return await _userService.GetUserByIdAsync(userId);
    }

}
