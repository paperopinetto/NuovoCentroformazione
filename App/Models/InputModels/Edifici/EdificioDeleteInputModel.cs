using System.ComponentModel.DataAnnotations;

namespace App.Models.InputModels.edifici
{
    public class EdificioDeleteInputModel
    {
        public int Id { get; set; }

        [Required]
        public string IdEdificio { get; set; }
    }
}