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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Game>().HasData(
            Suburban.Data.SeedData.games
        );
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Game> Games { get; set; }
}