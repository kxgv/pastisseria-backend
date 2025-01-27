using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    // Define aqu� tus DbSets (tablas)
    // Ejemplo:
    // public DbSet<User> Users { get; set; }
}
