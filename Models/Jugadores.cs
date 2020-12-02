using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DataVentasWeb.Models
{
    public class Jugadores
    {
        [Key]
        public int JugadorId { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir el nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir el tiempo")]
        public string Tiempo { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir el mensaje")]
        public string Mensaje { get; set; }


    }
}
