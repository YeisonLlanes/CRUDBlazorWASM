using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDBlazorWASM.Shared
{
    public class Usuario
    {
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "* Ogligatorio")]
        public string Nombre { get; set; } = null!;

        [Required(ErrorMessage = "* Ogligatorio")]
        public string Apellido { get; set; } = null!;
        
        [Required(ErrorMessage = "* Ogligatorio")]
        public string Email { get; set; } = null!;
        
        [Required(ErrorMessage = "* Ogligatorio")]
        public string Telefono { get; set; } = null!;

        public DateTime FechaIngreso { get; set; }

        public DateTime? FechaSalida { get; set; }
    }
}
