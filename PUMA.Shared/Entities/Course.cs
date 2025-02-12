using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUMA.Shared.Entities
{
    public class Course
    {
        public int Id { get; set; }
        [Required(ErrorMessage="El campo {0} es obligatorio")]
        [Display(Name="Nombre del curso")]
        [MaxLength(100,ErrorMessage ="El {0} debe de ser de {1} caracteres máximo")]
        public string? Name { get; set; }
        [Display(Name = "Descripción")]
        [MaxLength(250, ErrorMessage = "La {0} debe de ser de {1} caracteres máximo")]
        public string? Description { get; set; }
    }
}
