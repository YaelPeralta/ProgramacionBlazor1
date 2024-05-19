using BaseDeDatos.Data;
using Microsoft.EntityFrameworkCore;

namespace BaseDeDatos.Repositorio
{
    public class RepositorioSucursal : IRepositorioSucursal
    {
        private readonly TiendaDBContext _context;

        public RepositorioSucursal(TiendaDBContext context)
        {
            _context = context;
        }

        public async Task<Sucursal> Add(Sucursal sucursal)
        {
            await _context.Sucursales.AddAsync(sucursal);
            await _context.SaveChangesAsync();
            return sucursal;
        }

        public async Task Delete(int id)
        {
            var sucursal = await _context.Sucursales.FindAsync(id);
            if(sucursal != null)
            {
                _context.Sucursales.Remove(sucursal);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Sucursal?> Get(int id)
        {
            return await _context.Sucursales.FindAsync(id);
        }

        public async Task<List<Sucursal>> GetAll()
        {
            return await _context.Sucursales.ToListAsync();
        }

        public async Task Update(int id, Sucursal sucursal)
        {
            var sucursalactual = await _context.Sucursales.FindAsync(id);
            if(sucursalactual != null)
            {
                sucursalactual.Nombre = sucursal.Nombre;
                sucursalactual.Estado = sucursal.Estado;
                sucursalactual.Municipio = sucursal.Municipio;
                sucursalactual.Direccion = sucursal.Direccion;
                await _context.SaveChangesAsync();
            }
        }

    }
}
