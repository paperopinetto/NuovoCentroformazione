using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace App.Models.InputModels.Corsi
{
    public class CorsoEditInputModel
    {
        [Required]
        public int Id { get; set; }

        public string IdCorso { get; set; }

        [Required(ErrorMessage = "Il nominativo del dipartimento è obbligatorio"),
        Display(Name = "Codice dipartimento")]
        public string CodiceDipartimento { get; set; }

        [Required(ErrorMessage = "Edizione corso obbligatoria"),
        Display(Name = "Edizione Corso")]
        public string EdizioneCorso { get; set; }

        [Display(Name = "Nome corso")]
        public string NomeCorso { get; set; }

        [Display(Name = "Data inizio corso")]
        public string DataInizioCorso{ get; set; }

        [Display(Name = "Data fine corso")]
        public string DataFineCorso { get; set; }

        [Display(Name = "Ore corso")]
        public string OreCorso { get; set; }

        public string Note { get; set; }







    }
}
