using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _1372556_ProjetFinal.Models
{
    [Table("Pokemon")]
    public partial class Pokemon
    {
        [Key]
        [Column("idPokemon")]
        public int IdPokemon { get; set; }
        [Column("nom")]
        [StringLength(255)]
        [Unicode(false)]
        public string Nom { get; set; } = null!;
        [Column("niveau")]
        public int? Niveau { get; set; }
        [Column("idGeneration")]
        public int? IdGeneration { get; set; }
        [Column("idTypes")]
        public int? IdTypes { get; set; }

        [ForeignKey("IdGeneration")]
        [InverseProperty("Pokemons")]
        public virtual Generation? IdGenerationNavigation { get; set; }
        [ForeignKey("IdTypes")]
        [InverseProperty("Pokemons")]
        public virtual Typee? IdTypesNavigation { get; set; }
    }
}
