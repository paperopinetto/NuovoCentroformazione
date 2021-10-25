using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Razor.TagHelpers;
namespace App.Pages
{
    public class TestModel : PageModel
    {
        public void OnGet()
        {

        
        
        }


        public enum Dipartimento
        {


            [Display(Name = "Corso OSA")]
            CORSOOSA,

            [Display(Name = "Cucina")]
            CUCINA,

            [Display(Name = "Pasticcere")]
            PASTICCERE,

            [Display(Name = "Acconciatore Biennio")]
            ACCONCIATORE2,

            [Display(Name = "Acconciatore Terzo Anno")]
            ACCONCIATORE3,

            [Display(Name = "Estetista Biennio")]
            ESTETISTA2,

            [Display(Name = "Estetista Terzo Anno")]
            ESTETISTA3
        }

        public class DipartimentoModel
        {

            public Dipartimento dipartimento { get; set; }
        }

       




    }
}
