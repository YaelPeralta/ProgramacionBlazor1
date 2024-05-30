using System.ComponentModel.DataAnnotations;

namespace BaseDeDatos.Data
{
    public class Producto
    {
        public int ProductoId { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El precio es requerido")]
        public decimal Precio { get; set; }


        virtual public ICollection<Ticket>? Tickets { get; set; }
    }
}
