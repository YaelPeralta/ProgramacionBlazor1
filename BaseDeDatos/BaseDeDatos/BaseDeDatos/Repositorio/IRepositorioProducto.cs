using BaseDeDatos.Data;

namespace BaseDeDatos.Repositorio
{
    public interface IRepositorioProducto
    {
        Task<List<Producto>> GetAll();
        Task<Producto?> Get(int id);
        Task<Producto> Add(Producto sucursal);
        Task Update(int id, Producto sucursal);
        Task Delete(int id);
    }
}
