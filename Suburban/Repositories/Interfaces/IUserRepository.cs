using Suburban.Models;

namespace Suburban.Repositories.Interfaces;

public interface IUserRepository
{
    Task<User?> GetByEmailAsync(string email);

    Task<User> AddAsync(User user);

    Task<User?> GetByIdAsync(int id);

}