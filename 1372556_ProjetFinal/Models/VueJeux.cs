using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _1372556_ProjetFinal.Models
{
    [Keyless]
    public partial class VueJeux
    {
        public int IdJeux { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string NomJeu { get; set; } = null!;
        [Column(TypeName = "date")]
        public DateTime? DateSortie { get; set; }
        public int? Age { get; set; }
        public int? IdGeneration { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string Nom { get; set; } = null!;
    }
}
