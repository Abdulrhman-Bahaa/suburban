namespace Suburban.Data;

using Microsoft.EntityFrameworkCore;
using Suburban.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder
            .UseSnakeCaseNamingConvention();

    public DbSet<User> Users { get; set; }
}