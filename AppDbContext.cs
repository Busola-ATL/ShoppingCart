using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<ShoppingCart> ShoppingCarts { get; set; }

    // Constructor to configure database options (connection string, etc.)
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}
