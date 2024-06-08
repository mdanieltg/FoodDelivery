namespace FoodDelivery.HttpApi.Entities;

public class OrderDetail
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public Guid DishId { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
    public string? Instructions { get; set; }

    public Dish Dish { get; set; } = null!;
    public Order Order { get; set; } = null!;
}
