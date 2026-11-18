using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismoEnMovimiento.Class.Models
{
    public class SolicitudGemaModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(120)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [StringLength(250)]
        public string Direccion { get; set; } = string.Empty;

        [Required]
        [StringLength(150)]
        public string Correo { get; set; } = string.Empty;

        [Required]
        [StringLength(20)]
        public string Celular { get; set; } = string.Empty;

        [Required]
        [StringLength(120)]
        public string Profesion { get; set; } = string.Empty;

        [Required]
        [Range(1, 120)]
        public int Edad { get; set; }

        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}
