using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models.ViewModels.Lezioni
{
    public class LezioneViewModel
    {
        public int Id { get; set; }
        public int CorsoId { get; set; }
        public int DocenteId { get; set; }
        public string IdLezione { get; set; }
        public string NomeLezione { get; set; }
        public string CodiceCorso { get; set; }
        public string CodiceDocente { get; set; }
        public string CodiceAula { get; set; }
        public string DataInizioLezione { get; set; }
        public string DataFineLezione { get; set; }
        public string Note { get; set; }


    }
}
