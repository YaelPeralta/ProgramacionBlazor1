using BaseDeDatos.Data;

namespace BaseDeDatos.Repositorio
{
    public interface IRepositorioTicketes
    {
        Task<List<Ticket>> GetAll();
        Task<Ticket?> Get(int id);
        Task<Ticket> Add(Ticket ticket);
        Task Update(int id, Ticket ticket);
        Task Delete(int id);
    }
}
