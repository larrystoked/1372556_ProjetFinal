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
    public class TypesController : Controller
    {
        private readonly TP1_PokemonContext _context;

        public TypesController(TP1_PokemonContext context)
        {
            _context = context;
        }

        // GET: Types
        public async Task<IActionResult> Index()
        {
              return _context.Types != null ? 
                          View(await _context.Types.ToListAsync()) :
                          Problem("Entity set 'TP1_PokemonContext.Types'  is null.");
        }

        // GET: Types/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Types == null)
            {
                return NotFound();
            }

            var types = await _context.Types
                .FirstOrDefaultAsync(m => m.IdTypes == id);
            if (types == null)
            {
                return NotFound();
            }

            return View(types);
        }

        // GET: Types/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Types/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdTypes,NomType")] Types types)
        {
            if (ModelState.IsValid)
            {
                _context.Add(types);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(types);
        }

        // GET: Types/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Types == null)
            {
                return NotFound();
            }

            var types = await _context.Types.FindAsync(id);
            if (types == null)
            {
                return NotFound();
            }
            return View(types);
        }

        // POST: Types/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdTypes,NomType")] Types types)
        {
            if (id != types.IdTypes)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(types);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TypesExists(types.IdTypes))
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
            return View(types);
        }

        // GET: Types/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Types == null)
            {
                return NotFound();
            }

            var types = await _context.Types
                .FirstOrDefaultAsync(m => m.IdTypes == id);
            if (types == null)
            {
                return NotFound();
            }

            return View(types);
        }

        // POST: Types/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Types == null)
            {
                return Problem("Entity set 'TP1_PokemonContext.Types'  is null.");
            }
            var types = await _context.Types.FindAsync(id);
            if (types != null)
            {
                _context.Types.Remove(types);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TypesExists(int id)
        {
          return (_context.Types?.Any(e => e.IdTypes == id)).GetValueOrDefault();
        }
    }
}
