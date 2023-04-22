using Microsoft.EntityFrameworkCore;

public class DishDiscoveryContext : DbContext
{
    public DishDiscoveryContext(DbContextOptions<DishDiscoveryContext> options)
        : base(options)
    {
    }

    public DbSet<MenuItem> MenuItems { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }
    public DbSet<Recipe> Recipes { get; set; }
    public DbSet<Customer> Customers { get; set; }

    
}
