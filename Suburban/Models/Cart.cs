using System.ComponentModel.DataAnnotations;

namespace Suburban.Models;

public class Cart
{
    [Key]
    public string ProductId { get; set; }

    [Required]
    public int Quantity { get; set; }
}