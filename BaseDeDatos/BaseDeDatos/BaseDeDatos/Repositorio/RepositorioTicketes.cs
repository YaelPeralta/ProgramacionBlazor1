using BaseDeDatos.Data;
using Microsoft.EntityFrameworkCore;

namespace BaseDeDatos.Repositorio
{
    public class RepositorioTicketes : IRepositorioTicketes
    {
        private readonly TiendaDBContext _context;

        public RepositorioTicketes(TiendaDBContext context)
        {
            _context = context;
        }

        public async Task<Ticket> Add(Ticket ticket)
        {
            await _context.Ticketes.AddAsync(ticket);
            await _context.SaveChangesAsync();
            return ticket;
        }

        public async Task Delete(int id)
        {
            var ticket = await _context.Ticketes.FindAsync(id);
            if (ticket != null)
            {
                _context.Ticketes.Remove(ticket);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Ticket?> Get(int id)
        {
            return await _context.Ticketes
                .Include(t => t.Productos).Include(t => t.Sucursal)
                .FirstOrDefaultAsync(t => t.TicketId == id);
        }

        public async Task<List<Ticket>> GetAll()
        {
            return await _context.Ticketes
                .Include(t => t.Productos).Include(t => t.Sucursal)
                .ToListAsync();
        }

        public async Task Update(int id, Ticket ticket)
        {
            var ticketActual = await _context.Ticketes
                .Include(t => t.Productos)
                .FirstOrDefaultAsync(t => t.TicketId == id);

            if (ticketActual != null)
            {
                ticketActual.Fecha = ticket.Fecha;
                ticketActual.SucursalId = ticket.SucursalId;
                ticketActual.Productos = ticket.Productos;
                await _context.SaveChangesAsync();
            }
        }
    }
}
