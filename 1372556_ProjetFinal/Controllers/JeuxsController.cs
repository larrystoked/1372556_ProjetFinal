using _1372556_ProjetFinal.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Security.Claims;
using System.Security.Principal;

namespace _1372556_ProjetFinal.Controllers
{
    public class JeuxsController : Controller
    {

        readonly TP1_PokemonContext _context;

        public JeuxsController(TP1_PokemonContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

            return View();
        }
        public IActionResult Vuejeux()
        {
            // Utilisez Entity Framework pour récupérer les données de la vue SQL
            var customData = _context.VueJeuxes.ToList();

            return View("Vuejeux", customData); // Assurez-vous que le nom de la vue est correct ici
        }

    }
}
