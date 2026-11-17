using System.ComponentModel.DataAnnotations;

namespace TurismoEnMovimiento.Web.ViewModel
{
    public class SolicitudGemaViewModel
    {
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(120)]
        [Display(Name = "Nombre completo")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "La dirección es obligatoria.")]
        [StringLength(250)]
        [Display(Name = "Dirección")]
        public string Direccion { get; set; } = string.Empty;

        [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
        [EmailAddress(ErrorMessage = "Ingresa un correo electrónico válido.")]
        [StringLength(150)]
        [Display(Name = "Correo electrónico")]
        public string Correo { get; set; } = string.Empty;

        [Required(ErrorMessage = "El celular es obligatorio.")]
        [Phone(ErrorMessage = "Ingresa un número de celular válido.")]
        [StringLength(20)]
        [Display(Name = "Celular")]
        public string Celular { get; set; } = string.Empty;

        [Required(ErrorMessage = "La profesión es obligatoria.")]
        [StringLength(120)]
        [Display(Name = "Profesión")]
        public string Profesion { get; set; } = string.Empty;

        [Required(ErrorMessage = "La edad es obligatoria.")]
        [Range(1, 120, ErrorMessage = "Ingresa una edad válida.")]
        [Display(Name = "Edad")]
        public int? Edad { get; set; }
    }
}
