using _1372556_ProjetFinal.Data;
using Microsoft.AspNetCore.Mvc;

public class PokemonController : Controller
{
    private readonly TP1_PokemonContext _context;

    public PokemonController(TP1_PokemonContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> GetPokemonDetailsByGeneration(int generationId)
    {
        var pokemonDetails = await _context.GetPokemonDetailsByGenerationAsync(generationId);
        return View(pokemonDetails);
    }
}
