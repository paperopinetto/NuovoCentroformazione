using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using App.Models.InputModels.Lezioni;
using App.Models.Services.Infrastructure;

namespace App
{
    public class LezioniController : Controller
    {
        private readonly FormazioneDbContext _context;

        public LezioniController(FormazioneDbContext context)
        {
            _context = context;
        }

        // GET: Lezioni
        public async Task<IActionResult> Index()
        {
            return View(await _context.LezioneCreateInputModel.ToListAsync());
        }

        // GET: Lezioni/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lezioneCreateInputModel = await _context.LezioneCreateInputModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lezioneCreateInputModel == null)
            {
                return NotFound();
            }

            return View(lezioneCreateInputModel);
        }

        // GET: Lezioni/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Lezioni/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CorsoId,DocenteId,IdLezione,NomeLezione,CodiceCorso,CodiceDocente,CodiceAula,DataInizioLezione,DataFineLezione")] LezioneCreateInputModel lezioneCreateInputModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lezioneCreateInputModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lezioneCreateInputModel);
        }

        // GET: Lezioni/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lezioneCreateInputModel = await _context.LezioneCreateInputModel.FindAsync(id);
            if (lezioneCreateInputModel == null)
            {
                return NotFound();
            }
            return View(lezioneCreateInputModel);
        }

        // POST: Lezioni/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CorsoId,DocenteId,IdLezione,NomeLezione,CodiceCorso,CodiceDocente,CodiceAula,DataInizioLezione,DataFineLezione")] LezioneCreateInputModel lezioneCreateInputModel)
        {
            if (id != lezioneCreateInputModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lezioneCreateInputModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LezioneCreateInputModelExists(lezioneCreateInputModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(lezioneCreateInputModel);
        }

        // GET: Lezioni/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lezioneCreateInputModel = await _context.LezioneCreateInputModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lezioneCreateInputModel == null)
            {
                return NotFound();
            }

            return View(lezioneCreateInputModel);
        }

        // POST: Lezioni/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lezioneCreateInputModel = await _context.LezioneCreateInputModel.FindAsync(id);
            _context.LezioneCreateInputModel.Remove(lezioneCreateInputModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LezioneCreateInputModelExists(int id)
        {
            return _context.LezioneCreateInputModel.Any(e => e.Id == id);
        }
    }
}
