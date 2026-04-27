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
            new Game
            {
                Id = 1,
                Title = "The Witcher 3: Wild Hunt",
                Genre = "RPG",
                ReleaseDate = new DateTime(2015, 5, 19, 0, 0, 0, DateTimeKind.Utc),
                Rating = 9.8,
                Description = "An open-world RPG following Geralt of Rivia.",
                CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co1wyy.jpg"
            },
            new Game
            {
                Id = 2,
                Title = "Red Dead Redemption 2",
                Genre = "Action-Adventure",
                ReleaseDate = new DateTime(2018, 10, 26, 0, 0, 0, DateTimeKind.Utc),
                Rating = 9.7,
                Description = "A Wild West open-world story.",
                CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co1q1f.jpg"
            },
            new Game
            {
                Id = 3,
                Title = "Elden Ring",
                Genre = "Action RPG",
                ReleaseDate = new DateTime(2022, 2, 25, 0, 0, 0, DateTimeKind.Utc),
                Rating = 9.6,
                Description = "A challenging dark fantasy RPG.",
                CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co4jni.jpg"
            },
            new Game
            {
                Id = 4,
                Title = "God of War",
                Genre = "Action",
                ReleaseDate = new DateTime(2018, 4, 20, 0, 0, 0, DateTimeKind.Utc),
                Rating = 9.6,
                Description = "Kratos in Norse mythology.",
                CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co1tmu.jpg"
            },
            new Game
            {
                Id = 5,
                Title = "Cyberpunk 2077",
                Genre = "RPG",
                ReleaseDate = new DateTime(2020, 12, 10, 0, 0, 0, DateTimeKind.Utc),
                Rating = 8.5,
                Description = "Futuristic RPG in Night City.",
                CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co1rfi.jpg"
            },
            new Game
            {
                Id = 6,
                Title = "Horizon Zero Dawn",
                Genre = "Action RPG",
                ReleaseDate = new DateTime(2017, 2, 28, 0, 0, 0, DateTimeKind.Utc),
                Rating = 9.0,
                Description = "Hunting machines in a wild world.",
                CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co2lbd.jpg"
            },
            new Game
            {
                Id = 7,
                Title = "Assassin's Creed Valhalla",
                Genre = "Action RPG",
                ReleaseDate = new DateTime(2020, 11, 10, 0, 0, 0, DateTimeKind.Utc),
                Rating = 8.7,
                Description = "Viking conquest story.",
                CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co2ed3.jpg"
            },
            new Game
            {
                Id = 8,
                Title = "The Last of Us Part II",
                Genre = "Action-Adventure",
                ReleaseDate = new DateTime(2020, 6, 19, 0, 0, 0, DateTimeKind.Utc),
                Rating = 9.5,
                Description = "Emotional survival story.",
                CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co2y7h.jpg"
            },
            new Game
            {
                Id = 9,
                Title = "Spider-Man: Miles Morales",
                Genre = "Action",
                ReleaseDate = new DateTime(2020, 11, 12, 0, 0, 0, DateTimeKind.Utc),
                Rating = 9.0,
                Description = "Marvel superhero adventure.",
                CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co2dwe.jpg"
            },
            new Game
            {
                Id = 10,
                Title = "Forza Horizon 5",
                Genre = "Racing",
                ReleaseDate = new DateTime(2021, 11, 9, 0, 0, 0, DateTimeKind.Utc),
                Rating = 9.2,
                Description = "Open-world racing in Mexico.",
                CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co2l7u.jpg"
            },
            new Game
            {
                Id = 11,
                Title = "Baldur's Gate 3",
                Genre = "RPG",
                ReleaseDate = new DateTime(2023, 8, 3, 0, 0, 0, DateTimeKind.Utc),
                Rating = 9.8,
                Description = "A deep turn-based RPG based on Dungeons & Dragons.",
                CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co6d3e.jpg"
            },

            new Game
            {
                Id = 12,
                Title = "Resident Evil 4 Remake",
                Genre = "Survival Horror",
                ReleaseDate = new DateTime(2023, 3, 24, 0, 0, 0, DateTimeKind.Utc),
                Rating = 9.1,
                Description = "Reimagining of the classic survival horror experience.",
                CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co6l6a.jpg"
            },

            new Game
            {
                Id = 13,
                Title = "Starfield",
                Genre = "RPG",
                ReleaseDate = new DateTime(2023, 9, 6, 0, 0, 0, DateTimeKind.Utc),
                Rating = 8.2,
                Description = "A massive space exploration RPG from Bethesda.",
                CoverImageUrl = "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/1716740/header.jpg?t=1775743548"
            },

            new Game
            {
                Id = 14,
                Title = "Diablo IV",
                Genre = "Action RPG",
                ReleaseDate = new DateTime(2023, 6, 6, 0, 0, 0, DateTimeKind.Utc),
                Rating = 8.7,
                Description = "Dark fantasy dungeon-crawling action RPG.",
                CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co5s5p.jpg"
            },

            new Game
            {
                Id = 15,
                Title = "Hades",
                Genre = "Roguelike",
                ReleaseDate = new DateTime(2020, 9, 17, 0, 0, 0, DateTimeKind.Utc),
                Rating = 9.4,
                Description = "Fast-paced roguelike dungeon crawler with Greek mythology.",
                CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co2gfn.jpg"
            },

            new Game
            {
                Id = 16,
                Title = "Sekiro: Shadows Die Twice",
                Genre = "Action Adventure",
                ReleaseDate = new DateTime(2019, 3, 22, 0, 0, 0, DateTimeKind.Utc),
                Rating = 9.3,
                Description = "Challenging action game focused on precision combat.",
                CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co1q1e.jpg"
            },

            new Game
            {
                Id = 17,
                Title = "Death Stranding",
                Genre = "Action",
                ReleaseDate = new DateTime(2019, 11, 8, 0, 0, 0, DateTimeKind.Utc),
                Rating = 8.5,
                Description = "Unique open-world experience about connection and delivery.",
                CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co1q1g.jpg"
            },

            new Game
            {
                Id = 18,
                Title = "Ghost of Tsushima",
                Genre = "Action Adventure",
                ReleaseDate = new DateTime(2020, 7, 17, 0, 0, 0, DateTimeKind.Utc),
                Rating = 9.2,
                Description = "Open-world samurai adventure set in feudal Japan.",
                CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co2e7a.jpg"
            },

            new Game
            {
                Id = 19,
                Title = "DOOM Eternal",
                Genre = "FPS",
                ReleaseDate = new DateTime(2020, 3, 20, 0, 0, 0, DateTimeKind.Utc),
                Rating = 9.0,
                Description = "Fast-paced demon-slaying first-person shooter.",
                CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co2n7d.jpg"
            },

            new Game
            {
                Id = 20,
                Title = "The Legend of Zelda: Tears of the Kingdom",
                Genre = "Action Adventure",
                ReleaseDate = new DateTime(2023, 5, 12, 0, 0, 0, DateTimeKind.Utc),
                Rating = 9.7,
                Description = "Massive open-world adventure with creative freedom.",
                CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co6p5g.jpg"
            }
        );
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Game> Games { get; set; }
}