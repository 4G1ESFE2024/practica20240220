using Microsoft.EntityFrameworkCore;

namespace Practica20240220.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario { Email = "root@gmail.com", Id = 1, Nombre="root", Apellido="admin", Estatus=1, Rol= "Administrador",Password= "e10adc3949ba59abbe56e057f20f883e" }               
            );
        }
    }
}
