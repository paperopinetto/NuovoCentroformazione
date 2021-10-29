using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace App.Models.InputModels.Lezioni
{
    public class LezioneDeleteInputModel
    {

        public int Id { get; set; }

        [Required]
        public string IdLezione { get; set; }


    }
}
