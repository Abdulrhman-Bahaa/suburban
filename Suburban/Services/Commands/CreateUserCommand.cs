using Suburban.Models;
using Suburban.Services.Interfaces;

namespace Suburban.Services.Commands;

public class CreateUserCommand
{
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
}