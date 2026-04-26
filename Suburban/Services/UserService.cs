using Suburban.Repositories.Interfaces;
using Isopoh.Cryptography.Argon2;
using Suburban.Models;
using Suburban.DTOs;
using Suburban.Services.Commands;
using Suburban.Services.Interfaces;

namespace Suburban.Services;


class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<UserDto> GetUserByIdAsync(string id)
    {
        var user = await _userRepository.GetByIdAsync(int.Parse(id));
        if (user == null)
        {
            throw new InvalidOperationException("User not found.");
        }

        return new UserDto
        {
            Id = user.Id,
            Name = user.Name,
            Email = user.Email
        };
    }

}