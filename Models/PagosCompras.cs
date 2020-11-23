using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataVentasWeb.Models
{
    public class PagosCompras
    {
        [Key]
        public int PagoCompraId { get; set; }
        public virtual int CompraId { get; set; }
        public DateTime Fecha { get; set; }
        public double Monto { get; set; }
        public double Descuento { get; set; }
        public virtual int UsuarioId { get; set; }
    }
}
