using _1372556_ProjetFinal.Data;
using _1372556_ProjetFinal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class DresseursController : Controller
{
    private readonly TP1_PokemonContext _context;

    public DresseursController(TP1_PokemonContext context)
    {
        _context = context;
    }

    public IActionResult ChiffrerBadgeCount(int id)
    {
        _context.Database.ExecuteSqlRaw("EXEC ChiffrerDechiffrerBadgeCount @IdDresseur = {0}, @Action = 'Chiffrer'", id);
        return RedirectToAction(nameof(DetailsDecrypted), new { id });
    }

    public IActionResult DechiffrerBadgeCount(int id)
    {
        _context.Database.ExecuteSqlRaw("EXEC ChiffrerDechiffrerBadgeCount @IdDresseur = {0}, @Action = 'Dechiffrer'", id);
        return RedirectToAction(nameof(DetailsDecrypted), new { id });
    }

    public IActionResult DetailsDecrypted()
    {
        // Récupérez la liste des dresseurs depuis la base de données (ou d'où vous les obtenez)
        List<Dresseur> dresseurs = _context.Dresseurs.ToList();

        // Passez la liste des dresseurs à la vue
        return View(dresseurs);
    }

}
