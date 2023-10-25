using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _1372556_ProjetFinal.Models
{
    [Table("Generation")]
    public partial class Generation
    {
        public Generation()
        {
            Jeuxes = new HashSet<Jeux>();
            Pokemons = new HashSet<Pokemon>();
        }

        [Key]
        [Column("idGeneration")]
        public int IdGeneration { get; set; }
        [Column("numero")]
        public int Numero { get; set; }
        [Column("nom")]
        [StringLength(255)]
        [Unicode(false)]
        public string Nom { get; set; } = null!;
        [Column("nombreJeux")]
        public int NombreJeux { get; set; }

        [InverseProperty("IdGenerationNavigation")]
        public virtual ICollection<Jeux> Jeuxes { get; set; }
        [InverseProperty("IdGenerationNavigation")]
        public virtual ICollection<Pokemon> Pokemons { get; set; }
    }
}
