using FoodDelivery.HttpApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace FoodDelivery.HttpApi.DataAccess;

public class FoodDeliveryDbContext : DbContext
{
    public DbSet<Dish> Dishes { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<DeliveryPerson> DeliveryPersons { get; set; }

    public FoodDeliveryDbContext(DbContextOptions<FoodDeliveryDbContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Dish>(builder =>
        {
            //builder.Property(dish => dish.Id)
            // especificar index por medio de builder.HasIndex
            // Especificar Dish, Customer y DeliveryPerson
        });
        base.OnModelCreating(modelBuilder);
    }
}
