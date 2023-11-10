using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _1372556_ProjetFinal.ViewModels
{
    public class ImageUploadViewModel
    {
        [Required(ErrorMessage = "Veuillez sélectionner une image.")]
        public IFormFile FormFile { get; set; }

        [Required(ErrorMessage = "Veuillez spécifier le nom du Pokémon.")]
        [DisplayName("Nom du Pokémon")]
        public string NomPokemon { get; set; }
    }
}
