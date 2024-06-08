using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace FoodDelivery.HttpApi.Entities;

[DebuggerDisplay("Customer: {Name}")]
public class Customer
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string Phone { get; set; } = null!;

    public List<Order> Orders { get; set; } = new();
}
