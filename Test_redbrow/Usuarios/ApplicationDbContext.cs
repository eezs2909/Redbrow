using Microsoft.EntityFrameworkCore;
using Usuarios.Models;

namespace Usuarios
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Usuario>().Property(x => x.Nombre).HasMaxLength(300);
            modelBuilder.Entity<Usuario>().Property(x => x.Correo).HasMaxLength(100);
        }
        public DbSet<Usuario> Usuarios => Set<Usuario>();
    }
}
