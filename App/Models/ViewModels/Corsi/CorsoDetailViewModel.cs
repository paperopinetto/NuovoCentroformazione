﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models.ViewModels.Corsi
{
    public class CorsoDetailViewModel
    {
        public int Id { get; set; }
        public string IdCorso { get; set; }
        public string CodiceDipartimento { get; set; }
        public string EdizioneCorso { get; set; }
        public string NomeCorso { get; set; }
        public string DataInizioCorso { get; set; }
        public string DataFineCorso { get; set; }
        public string OreCorso { get; set; }
        public string Note { get; set; }



    }
}
