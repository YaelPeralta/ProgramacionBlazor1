using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace BaseDeDatos.Data
{
    public class Sucursal
    {
        public int SucursalId { get; set; }
        [Required(ErrorMessage ="El nombre es requerido")]
        [StringLength(100, ErrorMessage ="Máximo 100 caracteres")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El estado es requerido")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Estado { get; set; }

        [Required(ErrorMessage = "El municipio es requerido")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Municipio { get; set; }

        [Required(ErrorMessage = "La direccion es requerido")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Direccion {  get; set; }


        virtual public ICollection<Ticket>? Tickets { get; set; }

    }
}
