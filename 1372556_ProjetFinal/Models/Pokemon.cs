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
        public Pokemon()
        {
            IdDresseurs = new HashSet<Dresseur>();
            IdTypes = new HashSet<Types>();
        }

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
        [Column("niveauParDefaut")]
        public int? NiveauParDefaut { get; set; }

        [ForeignKey("IdGeneration")]
        [InverseProperty("Pokemons")]
        public virtual Generation? IdGenerationNavigation { get; set; }

        [ForeignKey("IdPokemon")]
        [InverseProperty("IdPokemons")]
        public virtual ICollection<Dresseur> IdDresseurs { get; set; }
        [ForeignKey("IdPokemon")]
        [InverseProperty("IdPokemons")]
        public virtual ICollection<Types> IdTypes { get; set; }
    }
}
