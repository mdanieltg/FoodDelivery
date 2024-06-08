using System.Diagnostics;

namespace FoodDelivery.HttpApi.Entities;

[DebuggerDisplay("Dish: {Name}")]
public class Dish
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public double Price { get; set; }

    public List<OrderDetail> OrderDetails { get; set; } = new();
}
