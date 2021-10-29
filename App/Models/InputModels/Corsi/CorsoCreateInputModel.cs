using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models.InputModels.Corsi
{
    public class CorsoCreateInputModel
    {
        public string NomeCorso { get; set; }
        public string DataInizioCorso { get; set; }
        public string DataFineCorso { get; set; }
        public string OreCorso { get; set; }
    }
}
