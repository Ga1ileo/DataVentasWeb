using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataVentasWeb.Models
{
    public class ComprasDetalles
    {
        [Key]
        public int CompraDetalleId { get; set; }
        public virtual int CompraId { get; set; }

        [Range(minimum: 1, maximum: double.MaxValue, ErrorMessage = "Debe seleccionar un producto")]
        [Required(ErrorMessage = "Debe seleccionar un producto")]
        public virtual int ProductoId { get; set; }

        [Range(minimum: 1, maximum: double.MaxValue, ErrorMessage = "La cantidad debe ser mayor a 1")]
        [Required(ErrorMessage = "Es obligatorio llenar la cantidad")]
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }

        public double Total { get; set; }
    }
}
