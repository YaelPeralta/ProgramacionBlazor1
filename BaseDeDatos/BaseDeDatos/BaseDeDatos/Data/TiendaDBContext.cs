
using Microsoft.EntityFrameworkCore;

namespace BaseDeDatos.Data
{
    public class TiendaDBContext : DbContext
    {
        public TiendaDBContext(DbContextOptions<TiendaDBContext> options) : base(options)
        {
            
        }
        public DbSet<Sucursal> Sucursales { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Ticket> Ticketes { get; set; }
    }
}
