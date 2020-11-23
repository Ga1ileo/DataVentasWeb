using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataVentasWeb.Models
{
    public class VentasDetalles
    {
        [Key]
        public int VentaDetalleId { get; set; }

        public virtual int VentaId { get; set; }

        [Range(minimum: 1, maximum: double.MaxValue, ErrorMessage = "Debe seleccionar un producto")]
        [Required(ErrorMessage = "Debe seleccionar un producto")]
        public virtual int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public double Total { get; set; }
    }
}
