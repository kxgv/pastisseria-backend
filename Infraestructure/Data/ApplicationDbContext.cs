using Microsoft.EntityFrameworkCore;
using Core.Entities;

namespace Infraestructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Users> Users { get; set; } // DbSet para la entidad User

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuraci�n de las entidades y relaciones
            modelBuilder.Entity<Users>()
                .HasIndex(u => u.Email)
                .IsUnique(); // Hace que el Email sea �nico

            modelBuilder.Entity<Users>()
                .HasIndex(u => u.UserName)
                .IsUnique(); // Hace que el UserName sea �nico
        }
    }
}