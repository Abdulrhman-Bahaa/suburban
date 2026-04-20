namespace Suburban.Models;

using System.ComponentModel.DataAnnotations;

public class User
{
    [Key]
    public required int Id { get; set; }

    [Required]
    public required string Name { get; set; }

    [Required]
    [EmailAddress]
    public required string Email { get; set; }

    [Required]
    public required string PasswordHash { get; set; }
}