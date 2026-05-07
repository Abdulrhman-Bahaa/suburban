
using Suburban.Models;

namespace Suburban.Data;

public static class SeedData
{
    public static Game[] games =
    {
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
        },
        new Game
        {
            Id = 21,
            Title = "Control",
            Genre = "Action Adventure",
            ReleaseDate = new DateTime(2019, 8, 27, 0, 0, 0, DateTimeKind.Utc),
            Rating = 8.8,
            Description = "Supernatural action game set in a shifting government building.",
            CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co1y6f.jpg"
        },
        new Game
        {
            Id = 22,
            Title = "Hollow Knight",
            Genre = "Metroidvania",
            ReleaseDate = new DateTime(2017, 2, 24, 0, 0, 0, DateTimeKind.Utc),
            Rating = 9.4,
            Description = "Beautifully crafted underground world full of secrets and challenge.",
            CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co1rgi.jpg"
        },
        new Game
        {
            Id = 23,
            Title = "Celeste",
            Genre = "Platformer",
            ReleaseDate = new DateTime(2018, 1, 25, 0, 0, 0, DateTimeKind.Utc),
            Rating = 9.2,
            Description = "Precision platforming with a heartfelt story.",
            CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co1rt6.jpg"
        },
        new Game
        {
            Id = 24,
            Title = "Dark Souls III",
            Genre = "Action RPG",
            ReleaseDate = new DateTime(2016, 3, 24, 0, 0, 0, DateTimeKind.Utc),
            Rating = 9.1,
            Description = "Challenging combat and dark fantasy storytelling.",
            CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co1vcf.jpg"
        },
        new Game
        {
            Id = 25,
            Title = "Bloodborne",
            Genre = "Action RPG",
            ReleaseDate = new DateTime(2015, 3, 24, 0, 0, 0, DateTimeKind.Utc),
            Rating = 9.3,
            Description = "Fast-paced gothic horror action RPG.",
            CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co1r7f.jpg"
        },
        new Game
        {
            Id = 26,
            Title = "Monster Hunter: World",
            Genre = "Action RPG",
            ReleaseDate = new DateTime(2018, 1, 26, 0, 0, 0, DateTimeKind.Utc),
            Rating = 9.0,
            Description = "Hunt massive creatures in a dynamic ecosystem.",
            CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co1r7x.jpg"
        },
        new Game
        {
            Id = 27,
            Title = "Persona 5 Royal",
            Genre = "JRPG",
            ReleaseDate = new DateTime(2020, 3, 31, 0, 0, 0, DateTimeKind.Utc),
            Rating = 9.6,
            Description = "Stylish turn-based RPG with deep social mechanics.",
            CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co1rmw.jpg"
        },
        new Game
        {
            Id = 28,
            Title = "Disco Elysium",
            Genre = "RPG",
            ReleaseDate = new DateTime(2019, 10, 15, 0, 0, 0, DateTimeKind.Utc),
            Rating = 9.5,
            Description = "Dialogue-driven RPG focused on choice and consequence.",
            CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co2lbd.jpg"
        },
        new Game
        {
            Id = 29,
            Title = "Cuphead",
            Genre = "Run and Gun",
            ReleaseDate = new DateTime(2017, 9, 29, 0, 0, 0, DateTimeKind.Utc),
            Rating = 8.9,
            Description = "Challenging boss battles with hand-drawn animation.",
            CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co1rsf.jpg"
        },
        new Game
        {
            Id = 30,
            Title = "Stardew Valley",
            Genre = "Simulation",
            ReleaseDate = new DateTime(2016, 2, 26, 0, 0, 0, DateTimeKind.Utc),
            Rating = 9.3,
            Description = "Relaxing farming and life simulation game.",
            CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co1x7k.jpg"
        },
        new Game
        {
            Id = 31,
            Title = "Subnautica",
            Genre = "Survival",
            ReleaseDate = new DateTime(2018, 1, 23, 0, 0, 0, DateTimeKind.Utc),
            Rating = 9.0,
            Description = "Explore an alien ocean world and survive its dangers.",
            CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co1mr3.jpg"
        },
        new Game
        {
            Id = 32,
            Title = "Outer Wilds",
            Genre = "Adventure",
            ReleaseDate = new DateTime(2019, 5, 28, 0, 0, 0, DateTimeKind.Utc),
            Rating = 9.4,
            Description = "Time-loop mystery across a handcrafted solar system.",
            CoverImageUrl = "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/753640/header.jpg?t=1729097431"
        },
        new Game
        {
            Id = 33,
            Title = "Dead Cells",
            Genre = "Roguelike",
            ReleaseDate = new DateTime(2018, 8, 7, 0, 0, 0, DateTimeKind.Utc),
            Rating = 9.1,
            Description = "Fast-paced roguelike with tight combat mechanics.",
            CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co1q7x.jpg"
        },
        new Game
        {
            Id = 34,
            Title = "It Takes Two",
            Genre = "Co-op Adventure",
            ReleaseDate = new DateTime(2021, 3, 26, 0, 0, 0, DateTimeKind.Utc),
            Rating = 9.5,
            Description = "Creative cooperative gameplay built around teamwork.",
            CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co2d7h.jpg"
        },
        new Game
        {
            Id = 35,
            Title = "Ratchet & Clank: Rift Apart",
            Genre = "Action Platformer",
            ReleaseDate = new DateTime(2021, 6, 11, 0, 0, 0, DateTimeKind.Utc),
            Rating = 9.2,
            Description = "Dimension-hopping action with stunning visuals.",
            CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co2k8t.jpg"
        },
        new Game
        {
            Id = 36,
            Title = "Final Fantasy VII Remake",
            Genre = "Action RPG",
            ReleaseDate = new DateTime(2020, 4, 10, 0, 0, 0, DateTimeKind.Utc),
            Rating = 9.0,
            Description = "Modern reimagining of a classic RPG.",
            CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co1vkk.jpg"
        },
        new Game
        {
            Id = 37,
            Title = "NieR: Automata",
            Genre = "Action RPG",
            ReleaseDate = new DateTime(2017, 3, 7, 0, 0, 0, DateTimeKind.Utc),
            Rating = 9.3,
            Description = "Philosophical sci-fi action with multiple endings.",
            CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co1r7e.jpg"
        },
        new Game
        {
            Id = 38,
            Title = "Mass Effect Legendary Edition",
            Genre = "RPG",
            ReleaseDate = new DateTime(2021, 5, 14, 0, 0, 0, DateTimeKind.Utc),
            Rating = 9.2,
            Description = "Remastered trilogy of a beloved sci-fi saga.",
            CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co2n2x.jpg"
        },
        new Game
        {
            Id = 39,
            Title = "The Elder Scrolls V: Skyrim",
            Genre = "RPG",
            ReleaseDate = new DateTime(2011, 11, 11, 0, 0, 0, DateTimeKind.Utc),
            Rating = 9.5,
            Description = "Epic open-world fantasy adventure.",
            CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co1nh1.jpg"
        },
        new Game
        {
            Id = 40,
            Title = "Far Cry 6",
            Genre = "FPS",
            ReleaseDate = new DateTime(2021, 10, 7, 0, 0, 0, DateTimeKind.Utc),
            Rating = 8.5,
            Description = "Open-world shooter set in a revolution-torn island.",
            CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co2o2k.jpg"
        },
        new Game
        {
            Id = 41,
            Title = "Metro Exodus",
            Genre = "FPS",
            ReleaseDate = new DateTime(2019, 2, 15, 0, 0, 0, DateTimeKind.Utc),
            Rating = 9.0,
            Description = "Story-driven survival shooter in post-apocalyptic Russia.",
            CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co1v0g.jpg"
        },
        new Game
        {
            Id = 42,
            Title = "The Division 2",
            Genre = "Shooter RPG",
            ReleaseDate = new DateTime(2019, 3, 15, 0, 0, 0, DateTimeKind.Utc),
            Rating = 8.7,
            Description = "Loot-based shooter set in a devastated Washington D.C.",
            CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co1u2k.jpg"
        },
        new Game
        {
            Id = 43,
            Title = "Watch Dogs: Legion",
            Genre = "Action Adventure",
            ReleaseDate = new DateTime(2020, 10, 29, 0, 0, 0, DateTimeKind.Utc),
            Rating = 8.3,
            Description = "Recruit anyone in a futuristic London resistance.",
            CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co2g7r.jpg"
        },
        new Game
        {
            Id = 44,
            Title = "Battlefield 2042",
            Genre = "FPS",
            ReleaseDate = new DateTime(2021, 11, 19, 0, 0, 0, DateTimeKind.Utc),
            Rating = 7.5,
            Description = "Large-scale multiplayer warfare with dynamic maps.",
            CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co2mvt.jpg"
        },
        new Game
        {
            Id = 45,
            Title = "Halo Infinite",
            Genre = "FPS",
            ReleaseDate = new DateTime(2021, 12, 8, 0, 0, 0, DateTimeKind.Utc),
            Rating = 8.9,
            Description = "Return of Master Chief in an open-world Halo experience.",
            CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co4gni.jpg"
        },
        new Game
        {
            Id = 46,
            Title = "Gears 5",
            Genre = "Third-Person Shooter",
            ReleaseDate = new DateTime(2019, 9, 10, 0, 0, 0, DateTimeKind.Utc),
            Rating = 8.8,
            Description = "Story-driven shooter with intense action sequences.",
            CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co20mh.jpg"
        },
        new Game
        {
            Id = 47,
            Title = "A Plague Tale: Requiem",
            Genre = "Action Adventure",
            ReleaseDate = new DateTime(2022, 10, 18, 0, 0, 0, DateTimeKind.Utc),
            Rating = 9.0,
            Description = "Emotional narrative set in a plague-ridden medieval world.",
            CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co5vmg.jpg"
        },
        new Game
        {
            Id = 48,
            Title = "Returnal",
            Genre = "Roguelike Shooter",
            ReleaseDate = new DateTime(2021, 4, 30, 0, 0, 0, DateTimeKind.Utc),
            Rating = 9.1,
            Description = "Sci-fi roguelike with intense combat and looping story.",
            CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co2c8l.jpg"
        },
        new Game
        {
            Id = 49,
            Title = "Sifu",
            Genre = "Action",
            ReleaseDate = new DateTime(2022, 2, 8, 0, 0, 0, DateTimeKind.Utc),
            Rating = 8.7,
            Description = "Martial arts combat with a unique aging mechanic.",
            CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co4jni.jpg"
        },
        new Game
        {
            Id = 50,
            Title = "Stray",
            Genre = "Adventure",
            ReleaseDate = new DateTime(2022, 7, 19, 0, 0, 0, DateTimeKind.Utc),
            Rating = 8.9,
            Description = "Play as a cat exploring a cyberpunk city.",
            CoverImageUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co4tt2.jpg"
        }
    };
}
