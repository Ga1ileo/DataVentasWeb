using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DataVentasWeb.Models
{
    public class Compras
    {
        [Key]
        public int CompraId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }

        [Range(minimum: 1, maximum: double.MaxValue, ErrorMessage = "Debe seleccionar un Forma de pago")]
        [Required(ErrorMessage = "Debe seleccionar un Forma de pago")]
        public string FormaPago { get; set; }

        [Required(ErrorMessage = "No puede estar vacio")]
        public double Monto { get; set; }
        
        public double Balance { get; set; }

        public double Descuento { get; set; }

        public double Devuelta { get; set; }

        public double Total { get; set; }
        public virtual int UsuarioId { get; set; }

        [ForeignKey("CompraId")]
        public virtual List<ComprasDetalles> ComprasDetalles { get; set; } = new List<ComprasDetalles>();
    }
}
