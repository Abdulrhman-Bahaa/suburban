
using Suburban.Services.Commands;
using Suburban.Models;

namespace Suburban.Services.Interfaces;


public interface IAuthService
{
    Task<string> LoginAsync(LoginCommand command);
    Task<string> RegisterAsync(CreateUserCommand command);
}