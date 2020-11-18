using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataVentasWeb.Models
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        [Required(ErrorMessage = "Es obligatorio introducir el nombre completo")]

        public string Nombres { get; set; }
        [Required(ErrorMessage = "Es obligatorio introducir el nombre de usuario")]

        public string NombreUsuario { get; set; }
        [Required(ErrorMessage = "Es obligatorio introducir el email")]
        
        public string Email { get; set; }
        [Required(ErrorMessage = "Es obligatorio introducir la clave")]
        public string Clave { get; set; }

    
    }

}