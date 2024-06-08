using System.Diagnostics;

namespace FoodDelivery.HttpApi.Entities;

[DebuggerDisplay("Delivery: {Name}")]
public class DeliveryPerson
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public DeliveryPersonStatus Status { get; set; }

    public List<Order> Orders { get; set; } = new();
}
