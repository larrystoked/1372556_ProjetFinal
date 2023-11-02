using System.Collections.Generic;
using _1372556_ProjetFinal.Models;

namespace _1372556_ProjetFinal.ViewModels
{
    public class PokemonViewModel
    {
        public int IdPokemon { get; set; }
        public string Nom { get; set; }
        public int? Niveau { get; set; }
        public int? IdGeneration { get; set; }
        public int? NiveauParDefaut { get; set; }

        // Ajoutez d'autres propriétés pour les informations de type, dresseur, etc. si nécessaire.

        public List<Types> Types { get; set; } // Pour stocker les informations de type.
        public List<Dresseur> Dresseurs { get; set; } // Pour stocker les informations de dresseur.
    }
}

