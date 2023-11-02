using _1372556_ProjetFinal.ViewModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1372556_ProjetFinal.Models
{
    [NotMapped]
    public class VwListeJeux
    {
        public List<JeuxComplexViewModel> JeuxComplexList { get; set; }
        public int IdJeux { get; set; }
        public string NomJeu { get; set; }
        public DateTime? DateSortie { get; set; }
        public int? Age { get; set; }
        public int? IdGeneration { get; set; }
        public string NomGeneration { get; set; }
        public int Prix { get; set; }
    }

}
