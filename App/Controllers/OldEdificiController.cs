using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using App.Models.InputModels.Edifici;
using App.Models.Services.Infrastructure;

namespace App
{
    public class OldEdificiController : Controller
    {
        private readonly FormazioneDbContext _context;

        public EdificiController(FormazioneDbContext context)
        {
            _context = context;
        }

        // GET: Edifici
        public async Task<IActionResult> Index()
        {
            return View(await _context.EdificioCreateInputModel.ToListAsync());
        }

        // GET: Edifici/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var edificioCreateInputModel = await _context.EdificioCreateInputModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (edificioCreateInputModel == null)
            {
                return NotFound();
            }

            return View(edificioCreateInputModel);
        }

        // GET: Edifici/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Edifici/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdEdificio,CodiceDipartimento,Aula,Laboratorio,Post")] EdificioCreateInputModel edificioCreateInputModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(edificioCreateInputModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(edificioCreateInputModel);
        }

        // GET: Edifici/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var edificioCreateInputModel = await _context.EdificioCreateInputModel.FindAsync(id);
            if (edificioCreateInputModel == null)
            {
                return NotFound();
            }
            return View(edificioCreateInputModel);
        }

        // POST: Edifici/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdEdificio,CodiceDipartimento,Aula,Laboratorio,Post")] EdificioCreateInputModel edificioCreateInputModel)
        {
            if (id != edificioCreateInputModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(edificioCreateInputModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EdificioCreateInputModelExists(edificioCreateInputModel.Id))
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
            return View(edificioCreateInputModel);
        }

        // GET: Edifici/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var edificioCreateInputModel = await _context.EdificioCreateInputModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (edificioCreateInputModel == null)
            {
                return NotFound();
            }

            return View(edificioCreateInputModel);
        }

        // POST: Edifici/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var edificioCreateInputModel = await _context.EdificioCreateInputModel.FindAsync(id);
            _context.EdificioCreateInputModel.Remove(edificioCreateInputModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EdificioCreateInputModelExists(int id)
        {
            return _context.EdificioCreateInputModel.Any(e => e.Id == id);
        }
    }
}
