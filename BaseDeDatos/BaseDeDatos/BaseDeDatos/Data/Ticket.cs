using System.ComponentModel.DataAnnotations.Schema;

namespace BaseDeDatos.Data
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public DateTime Fecha { get; set; }
        public int SucursalId { get; set; }
        public Sucursal? Sucursal { get; set; }
        public List<Producto> Productos { get; set; } = new List<Producto>();

        [NotMapped]
        public decimal CostoTotal { get; set; }
    }
}
