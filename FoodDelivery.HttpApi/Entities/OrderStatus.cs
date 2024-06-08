namespace FoodDelivery.HttpApi.Entities;

public enum OrderStatus
{
    Received,
    InPreparation,
    ReadyForDelivery,
    OutForDelivery,
    Delivered,
    Cancelled
}
