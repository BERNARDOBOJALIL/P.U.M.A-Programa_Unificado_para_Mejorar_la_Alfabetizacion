using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUMA.Shared.Entities
{
    public class Lesson
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Título")]
        [MaxLength(200, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Contenido")]
        [MaxLength(5000, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string? Content { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Dificultad")]
        [Range(1, 10, ErrorMessage = "El campo {0} debe estar entre {1} y {2}")]
        public int Difficulty { get; set; }
    }
}
