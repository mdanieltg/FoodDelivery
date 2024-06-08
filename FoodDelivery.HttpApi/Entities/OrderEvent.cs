using System.Diagnostics;

namespace FoodDelivery.HttpApi.Entities;

public class OrderEvent
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    public string Description { get; set; } = null!;
    public string? Details { get; set; }
    public Guid OrderId { get; set; }

    public Order Order { get; set; } = null!;
}
