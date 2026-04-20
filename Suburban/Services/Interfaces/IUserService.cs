using Suburban.Models;
using Suburban.DTOs;
using Suburban.Services.Commands;

namespace Suburban.Services.Interfaces;

public interface IUserService
{
    Task<UserDto> CreateUserAsync(CreateUserCommand command);
    // Task<UserDto?> GetUserByEmailAsync(string email);
    Task<UserDto> GetUserByIdAsync(string id);
}