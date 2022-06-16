using System.ComponentModel.DataAnnotations;

namespace ControlDeErrores.Models
{
    public class Persona
    {
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength(100, ErrorMessage = "El nombre no puede tener más de 100 caracteres")]
        [MinLength(2, ErrorMessage = "El nombre debe ser mayor a 2 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength(100, ErrorMessage = "El apellido no puede tener más de 100 caracteres")]
        public string Lastname { get; set; }

        [Required]
        [MaxLength(8, ErrorMessage = "El DNI de la persona debe ser como máximo de 8 caracteres")]
        [MinLength(8, ErrorMessage = "El DNI de la persona debe ser como mínimo de 8 caracteres")]
        public string DNI { get; set; }

        [Required(ErrorMessage = "La edad es obligatoria")]
        [Range(18,60, ErrorMessage = "La edad debe estar comprendida entre 18 y 60 años")]
        public int Edad { get; set; }
    }
}
