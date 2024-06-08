namespace FoodDelivery.HttpApi.Entities;

public class Order
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    public Guid CustomerId { get; set; }
    public Guid? DeliveryPersonId { get; set; }
    public OrderStatus Status { get; set; }
    public double Subtotal { get; set; }
    public double Tax { get; set; }
    public double Total { get; set; }

    public List<OrderDetail> OrderDetails { get; set; } = new();
    public Customer Customer { get; set; } = null!;
    public DeliveryPerson? DeliveryPerson { get; set; }
    public List<OrderEvent> OrderEvents { get; set; } = new();
}
