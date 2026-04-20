using Microsoft.EntityFrameworkCore;
using Suburban.Data;
using Suburban.Models;
using Suburban.Repositories.Interfaces;

namespace Suburban.Repositories;

class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;

    public UserRepository(AppDbContext context)
    {
        _context = context;
    }

    public Task<User?> GetByEmailAsync(string email)
    {
        return _context.Users.Where(u => u.Email == email)
            .Select(u => new User
            {
                Id = u.Id,
                Name = u.Name,
                Email = u.Email,
                PasswordHash = u.PasswordHash
            })
            .FirstOrDefaultAsync();
    }

    public async Task<User> AddAsync(User user)
    {
        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();

        return user;
    }

    public Task<User?> GetByIdAsync(int id)
    {
        return _context.Users.Where(u => u.Id == id)
            .Select(u => new User
            {
                Id = u.Id,
                Name = u.Name,
                Email = u.Email,
                PasswordHash = u.PasswordHash
            })
            .FirstOrDefaultAsync();
    }

}