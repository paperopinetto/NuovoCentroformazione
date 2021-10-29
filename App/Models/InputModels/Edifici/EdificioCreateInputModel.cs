using System.ComponentModel.DataAnnotations;
namespace App.Models.InputModels.Edifici
{
    public class EdificioCreateInputModel
    {
        public int Id { get; set; }
        public string IdEdificio { get; set; }
        [Required(ErrorMessage = "Il codice è obbligatorio"),
        Display(Name = "Codice dipartimento")]
        public string CodiceDipartimento { get; set; }
        [Required(ErrorMessage = "Nome aula obbligatorio")]
        public string Aula { get; set; }
        public string Laboratorio { get; set; }
        public string Post { get; set; }
    }
}