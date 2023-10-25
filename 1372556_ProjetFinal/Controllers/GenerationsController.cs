using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _1372556_ProjetFinal.Data;
using _1372556_ProjetFinal.Models;

namespace _1372556_ProjetFinal.Controllers
{
    public class GenerationsController : Controller
    {
        private readonly TP1_PokemonContext _context;

        public GenerationsController(TP1_PokemonContext context)
        {
            _context = context;
        }

        // GET: Generations
        public async Task<IActionResult> Index()
        {
              return _context.Generations != null ? 
                          View(await _context.Generations.ToListAsync()) :
                          Problem("Entity set 'TP1_PokemonContext.Generations'  is null.");
        }

        // GET: Generations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Generations == null)
            {
                return NotFound();
            }

            var generation = await _context.Generations
                .FirstOrDefaultAsync(m => m.IdGeneration == id);
            if (generation == null)
            {
                return NotFound();
            }

            return View(generation);
        }

        // GET: Generations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Generations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdGeneration,Numero,Nom,NombreJeux")] Generation generation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(generation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(generation);
        }

        // GET: Generations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Generations == null)
            {
                return NotFound();
            }

            var generation = await _context.Generations.FindAsync(id);
            if (generation == null)
            {
                return NotFound();
            }
            return View(generation);
        }

        // POST: Generations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdGeneration,Numero,Nom,NombreJeux")] Generation generation)
        {
            if (id != generation.IdGeneration)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(generation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GenerationExists(generation.IdGeneration))
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
            return View(generation);
        }

        // GET: Generations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Generations == null)
            {
                return NotFound();
            }

            var generation = await _context.Generations
                .FirstOrDefaultAsync(m => m.IdGeneration == id);
            if (generation == null)
            {
                return NotFound();
            }

            return View(generation);
        }

        // POST: Generations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Generations == null)
            {
                return Problem("Entity set 'TP1_PokemonContext.Generations'  is null.");
            }
            var generation = await _context.Generations.FindAsync(id);
            if (generation != null)
            {
                _context.Generations.Remove(generation);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GenerationExists(int id)
        {
          return (_context.Generations?.Any(e => e.IdGeneration == id)).GetValueOrDefault();
        }
    }
}
