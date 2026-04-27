using System.ComponentModel.DataAnnotations;

namespace Suburban.Models;

public class Game
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Genre { get; set; } = null!;
    public DateTime ReleaseDate { get; set; }
    public double Rating { get; set; }
    public string Description { get; set; } = null!;
    public string CoverImageUrl { get; set; } = null!;
}