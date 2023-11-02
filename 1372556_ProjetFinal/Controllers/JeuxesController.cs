using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _1372556_ProjetFinal.Data;
using _1372556_ProjetFinal.Models;
using _1372556_ProjetFinal.ViewModel;

namespace _1372556_ProjetFinal.Controllers
{
    public class JeuxesController : Controller
    {
        private readonly TP1_PokemonContext _context;

        public JeuxesController(TP1_PokemonContext context)
        {
            _context = context;
        }

        // GET: Jeuxes
        public async Task<IActionResult> Index()
        {
            var tP1_PokemonContext = _context.Jeuxes.Include(j => j.IdGenerationNavigation);
            return View(await tP1_PokemonContext.ToListAsync());
        }

        //VUE COMPLEXE

        public IActionResult IndexComplex()
        {
            var cutoffYear = 2010; // Année limite de filtrage
            var jeuxComplex = _context.JeuxComplexs
                            .Where(jeux => jeux.DateSortie.HasValue && jeux.DateSortie.Value.Year < cutoffYear)
                .ToList();

            var viewModel = new VwListeJeux
            {
                JeuxComplexList = jeuxComplex.Select(jeux => new JeuxComplexViewModel
                {
                    IdJeux = jeux.IdJeux,
                    NomJeu = jeux.NomJeu,
                    DateSortie = jeux.DateSortie,
                    Age = jeux.Age,
                    IdGeneration = jeux.IdGeneration,
                    NomGeneration = jeux.NomGeneration
                }).ToList()
            };

            return View(viewModel);
        }





        // GET: Jeuxes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Jeuxes == null)
            {
                return NotFound();
            }

            var jeux = await _context.Jeuxes
                .Include(j => j.IdGenerationNavigation)
                .FirstOrDefaultAsync(m => m.IdJeux == id);
            if (jeux == null)
            {
                return NotFound();
            }

            return View(jeux);
        }

        // GET: Jeuxes/Create
        public IActionResult Create()
        {
            ViewData["IdGeneration"] = new SelectList(_context.Generations, "IdGeneration", "IdGeneration");
            return View();
        }

        // POST: Jeuxes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdJeux,NomJeu,DateSortie,Age,IdGeneration")] Jeux jeux)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jeux);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdGeneration"] = new SelectList(_context.Generations, "IdGeneration", "IdGeneration", jeux.IdGeneration);
            return View(jeux);
        }

        // GET: Jeuxes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Jeuxes == null)
            {
                return NotFound();
            }

            var jeux = await _context.Jeuxes.FindAsync(id);
            if (jeux == null)
            {
                return NotFound();
            }
            ViewData["IdGeneration"] = new SelectList(_context.Generations, "IdGeneration", "IdGeneration", jeux.IdGeneration);
            return View(jeux);
        }

        // POST: Jeuxes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdJeux,NomJeu,DateSortie,Age,IdGeneration")] Jeux jeux)
        {
            if (id != jeux.IdJeux)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jeux);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JeuxExists(jeux.IdJeux))
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
            ViewData["IdGeneration"] = new SelectList(_context.Generations, "IdGeneration", "IdGeneration", jeux.IdGeneration);
            return View(jeux);
        }

        // GET: Jeuxes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Jeuxes == null)
            {
                return NotFound();
            }

            var jeux = await _context.Jeuxes
                .Include(j => j.IdGenerationNavigation)
                .FirstOrDefaultAsync(m => m.IdJeux == id);
            if (jeux == null)
            {
                return NotFound();
            }

            return View(jeux);
        }

        // POST: Jeuxes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Jeuxes == null)
            {
                return Problem("Entity set 'TP1_PokemonContext.Jeuxes'  is null.");
            }
            var jeux = await _context.Jeuxes.FindAsync(id);
            if (jeux != null)
            {
                _context.Jeuxes.Remove(jeux);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JeuxExists(int id)
        {
          return (_context.Jeuxes?.Any(e => e.IdJeux == id)).GetValueOrDefault();
        }

        //Chiffrer
        public IActionResult ChiffrerPrixDuJeu(int id)
        {
            
            _context.ChiffrerPrixJeux(id);

            

            return RedirectToAction("Index"); 
        }

        //Dechiffrer
        public IActionResult DechiffrerPrix(int id)
        {
            _context.DechiffrerPrixJeux(id);
            return RedirectToAction(nameof(Index));
        }




    }
}
