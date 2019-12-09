using Microsoft.EntityFrameworkCore;

namespace ApiUsuario.Models
{
    public class UsuarioDdContext : DbContext
    {
         public UsuarioDdContext(DbContextOptions<UsuarioDdContext> options)
         : base (options)
        { }

        public DbSet<Usuario> Usuarios {get;set;}
    }
}