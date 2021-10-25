using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Models.InputModels.Edifici;

using App.Models.ViewModels;
using App.Models.Services.Infrastructure;
using Microsoft.EntityFrameworkCore;
using App.Models.Entities;
using App.Models.ViewModels.edifici;
using App.Models.InputModels.edifici;

namespace App.Controllers
{
    public class EdificiController : Controller
    {

        private readonly FormazioneDbContext formazioneDbContext;

        public EdificiController(Models.Services.Infrastructure.FormazioneDbContext dbContext)
        {
           formazioneDbContext = dbContext;
        }




        // public IActionResult Index()
        //{
        //  return View();
        //  }

        public async Task<IActionResult> Index()
        {
            return View(await formazioneDbContext.Edifici.ToListAsync());
        }

        public IActionResult Create()
        {
            ViewData["Title"] = "Creazione nuovo edificio";
            EdificioCreateInputModel inputModel = new();

            return View(inputModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task< IActionResult> Create(EdificioCreateInputModel inputModel)
        {
            string CodiceDipartimento = inputModel.CodiceDipartimento;
            string Aula = inputModel.Aula;
            string Laboratorio = inputModel.Laboratorio;
            string Posti = inputModel.Post;
            var edificio = new Edificio(CodiceDipartimento, Aula, Laboratorio, Posti);

            
               formazioneDbContext .Add(edificio);
              await formazioneDbContext.SaveChangesAsync();

            TempData["ConfirmationMessage"] = "La scheda è stata creata con successo";
            return RedirectToAction(nameof(Index));
            //}
           // return View(inputModel);
        }

        public async Task<ActionResult> Detail(EdificioDetailViewModel inputModel)
        {

            Edificio edificio = await formazioneDbContext.Edifici.FirstOrDefaultAsync(m => m.IdEdificio == inputModel.IdEdificio.ToString());
            edificio.ChangeLaboratorio(inputModel.Laboratorio);
            await formazioneDbContext.SaveChangesAsync();




            // return EdificioDetailViewModel.fromEntity(edificio)
            return View(inputModel);

        }

        //public async Task<IActionResult> Detail(int? idedificio)
        //{
        //    if (idedificio == null)
        //    {
        //        return NotFound();
        //    }
        //    var employee = await formazioneDbContext.Edifici.FirstOrDefaultAsync(m => m.IdEdificio == idedificio.ToString());
        //    if (employee == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(EdificioCreateInputModel);
        //}












        public ActionResult Edit(EdificioCreateInputModel inputModel)
        {

            return View(inputModel);
        }





    }
}
