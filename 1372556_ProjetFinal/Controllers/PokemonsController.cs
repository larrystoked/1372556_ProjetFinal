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
    public class PokemonsController : Controller
    {
        private readonly TP1_PokemonContext _context;

        public PokemonsController(TP1_PokemonContext context)
        {
            _context = context;
        }

        // GET: Pokemons
        public async Task<IActionResult> Index()
        {
            var tP1_PokemonContext = _context.Pokemons.Include(p => p.IdGenerationNavigation);
            return View(await tP1_PokemonContext.ToListAsync());
        }

        // GET: Pokemons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Pokemons == null)
            {
                return NotFound();
            }

            var pokemon = await _context.Pokemons
                .Include(p => p.IdGenerationNavigation)
                .FirstOrDefaultAsync(m => m.IdPokemon == id);
            if (pokemon == null)
            {
                return NotFound();
            }

            return View(pokemon);
        }

        // GET: Pokemons/Create
        public IActionResult Create()
        {
            ViewData["IdGeneration"] = new SelectList(_context.Generations, "IdGeneration", "IdGeneration");
            return View();
        }

        // POST: Pokemons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPokemon,Nom,Niveau,IdGeneration,NiveauParDefaut")] Pokemon pokemon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pokemon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdGeneration"] = new SelectList(_context.Generations, "IdGeneration", "IdGeneration", pokemon.IdGeneration);
            return View(pokemon);
        }

        // GET: Pokemons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Pokemons == null)
            {
                return NotFound();
            }

            var pokemon = await _context.Pokemons.FindAsync(id);
            if (pokemon == null)
            {
                return NotFound();
            }
            ViewData["IdGeneration"] = new SelectList(_context.Generations, "IdGeneration", "IdGeneration", pokemon.IdGeneration);
            return View(pokemon);
        }

        // POST: Pokemons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPokemon,Nom,Niveau,IdGeneration,NiveauParDefaut")] Pokemon pokemon)
        {
            if (id != pokemon.IdPokemon)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pokemon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PokemonExists(pokemon.IdPokemon))
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
            ViewData["IdGeneration"] = new SelectList(_context.Generations, "IdGeneration", "IdGeneration", pokemon.IdGeneration);
            return View(pokemon);
        }

        // GET: Pokemons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Pokemons == null)
            {
                return NotFound();
            }

            var pokemon = await _context.Pokemons
                .Include(p => p.IdGenerationNavigation)
                .FirstOrDefaultAsync(m => m.IdPokemon == id);
            if (pokemon == null)
            {
                return NotFound();
            }

            return View(pokemon);
        }

        // POST: Pokemons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Pokemons == null)
            {
                return Problem("Entity set 'TP1_PokemonContext.Pokemons'  is null.");
            }
            var pokemon = await _context.Pokemons.FindAsync(id);
            if (pokemon != null)
            {
                _context.Pokemons.Remove(pokemon);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PokemonExists(int id)
        {
          return (_context.Pokemons?.Any(e => e.IdPokemon == id)).GetValueOrDefault();
        }
    }
}
