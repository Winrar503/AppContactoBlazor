using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AppContactBlazro.Models
{
    public class Contacto
    {
        public int Id { get; set; }
        public int CategoriasId { get; set; }
        public bool Eliminado { get; set; } = false;
        public string Email { get; set; }
        public string FotoPath { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El numero es requerido")]
        public string Numero { get; set; }
        public string QrCodePath { get; set; }

        //[NotMapped]
        //[ValidateNever]
        //public Categorias Categorias { get; set; }
        //[NotMapped]
        //public int Top_Aux { get; set; }
        //[ValidateNever]
        //public List<Eventos> Eventos { get; set; }
        //[ValidateNever]
        //public List<Notas> Notas { get; set; }

    }
}
