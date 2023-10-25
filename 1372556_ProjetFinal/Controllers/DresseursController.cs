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
    public class DresseursController : Controller
    {
        private readonly TP1_PokemonContext _context;

        public DresseursController(TP1_PokemonContext context)
        {
            _context = context;
        }

        // GET: Dresseurs
        public async Task<IActionResult> Index()
        {
              return _context.Dresseurs != null ? 
                          View(await _context.Dresseurs.ToListAsync()) :
                          Problem("Entity set 'TP1_PokemonContext.Dresseurs'  is null.");
        }

        // GET: Dresseurs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Dresseurs == null)
            {
                return NotFound();
            }

            var dresseur = await _context.Dresseurs
                .FirstOrDefaultAsync(m => m.IdDresseur == id);
            if (dresseur == null)
            {
                return NotFound();
            }

            return View(dresseur);
        }

        // GET: Dresseurs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dresseurs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdDresseur,Nom,Prenom,BadgeCount")] Dresseur dresseur)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dresseur);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dresseur);
        }

        // GET: Dresseurs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Dresseurs == null)
            {
                return NotFound();
            }

            var dresseur = await _context.Dresseurs.FindAsync(id);
            if (dresseur == null)
            {
                return NotFound();
            }
            return View(dresseur);
        }

        // POST: Dresseurs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdDresseur,Nom,Prenom,BadgeCount")] Dresseur dresseur)
        {
            if (id != dresseur.IdDresseur)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dresseur);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DresseurExists(dresseur.IdDresseur))
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
            return View(dresseur);
        }

        // GET: Dresseurs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Dresseurs == null)
            {
                return NotFound();
            }

            var dresseur = await _context.Dresseurs
                .FirstOrDefaultAsync(m => m.IdDresseur == id);
            if (dresseur == null)
            {
                return NotFound();
            }

            return View(dresseur);
        }

        // POST: Dresseurs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Dresseurs == null)
            {
                return Problem("Entity set 'TP1_PokemonContext.Dresseurs'  is null.");
            }
            var dresseur = await _context.Dresseurs.FindAsync(id);
            if (dresseur != null)
            {
                _context.Dresseurs.Remove(dresseur);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DresseurExists(int id)
        {
          return (_context.Dresseurs?.Any(e => e.IdDresseur == id)).GetValueOrDefault();
        }
    }
}
