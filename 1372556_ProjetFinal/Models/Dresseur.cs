using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _1372556_ProjetFinal.Models
{
    [Table("Dresseur")]
    public partial class Dresseur
    {
        public Dresseur()
        {
            IdPokemons = new HashSet<Pokemon>();
        }

        [Key]
        [Column("idDresseur")]
        public int IdDresseur { get; set; }
        [Column("nom")]
        [StringLength(255)]
        [Unicode(false)]
        public string Nom { get; set; } = null!;
        [Column("prenom")]
        [StringLength(255)]
        [Unicode(false)]
        public string Prenom { get; set; } = null!;
        [Column("badgeCount")]
        public int? BadgeCount { get; set; }

        [ForeignKey("IdDresseur")]
        [InverseProperty("IdDresseurs")]
        public virtual ICollection<Pokemon> IdPokemons { get; set; }
    }
}
