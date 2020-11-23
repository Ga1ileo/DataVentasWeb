using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DataVentasWeb.Models
{
    public class Ventas
    {
        [Key]
        public int VentaId { get; set; }
        public virtual int VendedorId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "Seleccione un cliente")]
        [Range(minimum: 1, maximum: double.MaxValue, ErrorMessage = "Debe seleccionar un cliente")]
        public virtual int ClienteId { get; set; }

        [Required(ErrorMessage = "Seleccione un Forma de pago")]
        [Range(minimum: 1, maximum: double.MaxValue, ErrorMessage = "Debe seleccionar un Forma de pago")]
        public string FormaPago { get; set; }
        public string Devuelta { get; set; }
        public double Balance { get; set; }
        public double Total { get; set; }
        public double Descuento { get; set; }
        public virtual int UsuarioId { get; set; }


        [ForeignKey("VentaId")]
        public virtual List<VentasDetalles> VentasDetalles { get; set; }
    }
}
