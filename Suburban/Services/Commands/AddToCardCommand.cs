using Suburban.Models;

namespace Suburban.Services.Commands;

public class AddToCardCommand
{
    public string UserId { get; set; }
    public string ProductId { get; set; }
    public int Quantity { get; set; }
}
