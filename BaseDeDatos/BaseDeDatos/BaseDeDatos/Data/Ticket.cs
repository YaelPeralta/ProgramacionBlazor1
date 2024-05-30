using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace BaseDeDatos.Data
{
    public class Ticket
    {
        public int TicketId { get; set; }
        [Required(ErrorMessage = "La fecha es requerida")]
        public DateOnly? Fecha { get; set; }
        [Required(ErrorMessage = "El costo total es requerido")]
        public decimal? CostoTotal { get; set; }

        //Uno a muchos
        public int SucursalId { get; set; }
        virtual public Sucursal? Sucursal { get; set; }

        //Muchos a muchos
        virtual public ICollection<Producto>? Productos { get; set; }


    }
}
