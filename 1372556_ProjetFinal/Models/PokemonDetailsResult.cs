using Microsoft.EntityFrameworkCore;

namespace _1372556_ProjetFinal.Models
{
    [Keyless]
    public class PokemonDetailsResult
    {
        public string PokemonNom { get; set; }
        public int? Niveau { get; set; }
        public string GenerationNom { get; set; }
    }
}
