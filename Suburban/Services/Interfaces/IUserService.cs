using Suburban.Models;
using Suburban.DTOs;
using Suburban.Services.Commands;

namespace Suburban.Services.Interfaces;

public interface IUserService
{
    Task<UserDto> GetUserByIdAsync(string id);
}