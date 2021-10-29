using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace App.Models.InputModels.Lezioni
{
    public class LezioneEditInputModel
    {

        public int Id { get; set; }
        public int CorsoId { get; set; }
        public int DocenteId { get; set; }
        public string IdLezione { get; set; }

        [Required(ErrorMessage = "Il nome lezione è obbligatorio"),
        Display(Name = "Nome Lezione")]
        public string NomeLezione { get; set; }
        public string CodiceCorso { get; set; }
        public string CodiceDocente { get; set; }
        public string CodiceAula { get; set; }
        public string DataInizioLezione { get; set; }
        public string DataFineLezione { get; set; }
        public string Note { get; set; }
      //  public virtual Corso Corso { get; set; }
        //public virtual Docente Docente { get; set; }














    }
}
