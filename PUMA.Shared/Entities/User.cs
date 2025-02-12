using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUMA.Shared.Entities
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Correo")]
        [MaxLength(70, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Contraseña")]
        [MaxLength(255, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Racha de puntos")]
        public int Scorestreak { get; set; } = 0;

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Rol")]
        [MaxLength(30, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string Role { get; private set; } = "Estudiante";

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Activo")]
        public bool Active { get; set; } = true;
    }
}
