using Isopoh.Cryptography.Argon2;
using Suburban.Services.Commands;
using Suburban.Repositories.Interfaces;
using Suburban.Services.Interfaces;
using Suburban.Models;

namespace Suburban.Services;


public class AuthService : IAuthService
{
    private readonly IUserRepository _userRepository;
    private readonly IJwtService _jwtService;

    public AuthService(IUserRepository userRepository, IJwtService jwtService)
    {
        _userRepository = userRepository;
        _jwtService = jwtService;
    }

    public async Task<string> RegisterAsync(CreateUserCommand command)
    {

        var user = await _userRepository.GetByEmailAsync(command.Email);
        if (user != null)
        {
            throw new InvalidOperationException("User with this email already exists.");
        }

        user = new User
        {
            Id = 0, // Will be set by the database
            Name = command.Name,
            Email = command.Email,
            PasswordHash = Argon2.Hash(command.Password)
        };

        var createdUser = await _userRepository.AddAsync(user);

        return createdUser.Id.ToString(); // Return user ID or any other relevant information
    }

    public async Task<string> LoginAsync(LoginCommand command)
    {
        var user = await _userRepository.GetByEmailAsync(command.Email);
        if (user == null)
        {
            throw new InvalidOperationException("Invalid email or password.");
        }

        if (!Argon2.Verify(user.PasswordHash, command.Password))
        {
            throw new InvalidOperationException("Invalid email or password.");
        }

        // Return a JWT token or any other authentication token
        return _jwtService.GenerateToken(user.Id.ToString(), user.Email, "User");
    }
}