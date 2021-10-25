using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Models.InputModels.Corsi;
namespace App.Controllers
{
    public class CorsiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            ViewData["Title"] = "Creazione nuovo corso";
            CorsoCreateInputModel inputModel = new();

            return View(inputModel);
        }






    }
}
