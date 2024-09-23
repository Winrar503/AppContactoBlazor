using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;

namespace AppContactBlazro.Data.DTOs
{
    public class ContactDTO
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "la categoría es obligatoria.")]
        public int categoriasid { get; set; }

        public bool Eliminado { get; set; } = false;

        [Required(ErrorMessage = "El email es obligatorio.")]
        [EmailAddress(ErrorMessage = "Formato de email no válido.")]
        public string Email { get; set; }

        public string FotoPath { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El número es obligatorio.")]
        [Phone(ErrorMessage = "Formato de número de teléfono no válido.")]
        public string Numero { get; set; }

        public string QrCodePath { get; set; }

        // Estas propiedades no son necesarias en el cliente, pero si las quieres mantener:
        //public Categorias Categorias { get; set; }
        //public int Top_Aux { get; set; }
        //public List<Eventos> Eventos { get; set; }
        //public List<Notas> Notas { get; set; }
    }
}