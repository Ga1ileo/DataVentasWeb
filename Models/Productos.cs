using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataVentasWeb.Models
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir la descripcion")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir la cantidad existente")]
        [Range(minimum: 1, maximum: double.MaxValue, ErrorMessage = "La cantidad existente debe ser mayor a 1")]
        public int Cantidad { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir el precio")]
        [Range(minimum: 1, maximum: double.MaxValue, ErrorMessage = "El precio debe ser mayor a 1")]
        public double Precio { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir el costo")]
        [Range(minimum: 1, maximum: double.MaxValue, ErrorMessage = "El costo debe ser mayor a 1")]
        public double Costo { get; set; }
        public virtual int UsuarioId { get; set; }
    }
}
