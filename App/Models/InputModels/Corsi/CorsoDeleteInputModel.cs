using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace App.Models.InputModels.Corsi
{
    public class CorsoDeleteInputModel
    {
        public int Id { get; set; }

        [Required]
        public string IdCorso { get; set; }

    }
}
