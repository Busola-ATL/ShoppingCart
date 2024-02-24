using Microsoft.EntityFrameworkCore;

public class SecurityDbContext : DbContext
{
    // DbSet properties for your Security entities
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    // Add other DbSet properties as needed

    // Constructor to configure database options (connection string, etc.)
    public SecurityDbContext(DbContextOptions<SecurityDbContext> options) : base(options)
    {
    }

    // Additional configuration (e.g., model building, seed data) can go here
}
