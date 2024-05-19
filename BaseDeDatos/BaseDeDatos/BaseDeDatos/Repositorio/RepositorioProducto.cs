using BaseDeDatos.Data;
using Microsoft.EntityFrameworkCore;

namespace BaseDeDatos.Repositorio
{
    public class RepositorioProducto : IRepositorioProducto
    {
        private readonly TiendaDBContext _context;

        public RepositorioProducto(TiendaDBContext context)
        {
            _context = context;
        }

        public async Task<Producto> Add(Producto producto)
        {
            await _context.Productos.AddAsync(producto);
            await _context.SaveChangesAsync();
            return producto;
        }

        public async Task Delete(int id)
        {
            var producto = await _context.Productos.FindAsync(id);
            if (producto != null)
            {
                _context.Productos.Remove(producto);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Producto?> Get(int id)
        {
            return await _context.Productos.FindAsync(id);
        }

        public async Task<List<Producto>> GetAll()
        {
            return await _context.Productos.ToListAsync();
        }

        public async Task Update(int id, Producto producto)
        {
            var sucursalactual = await _context.Productos.FindAsync(id);
            if (sucursalactual != null)
            {
                sucursalactual.Nombre = producto.Nombre;
                sucursalactual.Precio = producto.Precio;
                await _context.SaveChangesAsync();
            }
        }
    }
}
