using System.ComponentModel.DataAnnotations;

namespace App.Models.InputModels.Edifici
{
    public class EdificioEditInputModel
    {
        // [Required]
        public int Id { get; set; }
        
        public string IdEdificio { get; set; }

        // [Required(ErrorMessage = "Il codice è obbligatorio"),
        // Display(Name = "Codice dipartimento")]
        [Display(Name = "Codice dipartimento")]
        public string CodiceDipartimento { get; set; }

        // [Required(ErrorMessage = "Nome aula obbligatorio"),
        // Display(Name ="Aula")]
        [Display(Name ="Aula")]
        public string Aula { get; set; }

        [Display(Name ="Indirizzo")]
        public string Indirizzo { get; set; }

        [Display(Name ="Piano")]
        public string Piano { get; set; }

        [Display(Name ="Metri Quadri")]
        public string Mq { get; set; }

        // [Required(ErrorMessage = "Il laboratorio è obbligatorio"),
        // Display(Name ="Laboratorio")]
        [Display(Name ="Laboratorio")]
        public string Laboratorio { get; set; }
        
        // [Required(ErrorMessage = "Il numero dei posti è obbligatorio"),
        // Display(Name ="Posti")]
        [Display(Name ="Posti")]
        public string Posti { get; set; }

        [Display(Name ="Note")]
        public string Note { get; set; }
    }
}