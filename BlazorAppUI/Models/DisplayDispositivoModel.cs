using System.ComponentModel.DataAnnotations;

namespace BlazorAppUI.Models
{
    public class DisplayDispositivoModel
    {
        [Required]
        [StringLength(15, ErrorMessage = "Matricola troppo lunga")]
        [MinLength(5, ErrorMessage = "Matricola troppo corta")]
        public string Matricola { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "Descrizione troppo lunga")]
        [MinLength(5, ErrorMessage = "Descrizione troppo corta")]
        public string Descrizione { get; set; }
        [Required]
        [StringLength(5, ErrorMessage = "Modello troppo lunga")]
        [MinLength(3, ErrorMessage = "Modello troppo corta")]
        public string Modello { get; set; }
    }
}
