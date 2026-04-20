namespace Suburban.Services.Interfaces;

using Suburban.Services.Commands;

public interface IAuthService
{
    Task<string> LoginAsync(LoginCommand command);
}