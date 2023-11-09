using Microsoft.AspNetCore.Mvc;
using _1372556_ProjetFinal.Data;

namespace _1372556_ProjetFinal.Controllers
{
    public class HomeController : Controller
    {
        private readonly TP1_PokemonContext _context;

        public HomeController(TP1_PokemonContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RedirectVueJeux()
        {
            // Utilisez Entity Framework pour récupérer les données de la vue SQL si nécessaire
            var customData = _context.VueJeuxes.ToList();

            // Redirigez vers l'action "VueJeux" dans le contrôleur "Jeuxs"
            return RedirectToAction("VueJeux", "Jeuxs", customData);
        }

        public IActionResult RedirectToDetailsDecrypted(int id)
        {
            // Redirige vers l'action DetailsDecrypted du DresseursController avec l'ID spécifié
            return RedirectToAction("DetailsDecrypted", "Dresseurs", new { id = id });
        }
    }
}
