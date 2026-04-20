using Isopoh.Cryptography.Argon2;
using Suburban.Services.Commands;
using Suburban.Repositories.Interfaces;
using Suburban.Services.Interfaces;

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