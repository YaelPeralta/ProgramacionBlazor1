using BaseDeDatos.Data;

namespace BaseDeDatos.Repositorio
{
    public interface IRepositorioSucursal
    {
        Task<List<Sucursal>> GetAll();
        Task<Sucursal?> Get(int id);
        Task<Sucursal> Add(Sucursal sucursal);
        Task Update(int id, Sucursal sucursal);
        Task Delete(int id);
    }
}
