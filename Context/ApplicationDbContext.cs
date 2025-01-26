using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    // Define aquí tus DbSets (tablas)
    // Ejemplo:
    // public DbSet<User> Users { get; set; }
}
