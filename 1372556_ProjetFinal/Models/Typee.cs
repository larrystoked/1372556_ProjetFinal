using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _1372556_ProjetFinal.Models
{
    [Table("Typee")]
    [Index("NomTypes", Name = "UQ__Typee__47448AB74058B709", IsUnique = true)]
    public partial class Typee
    {
        public Typee()
        {
            Pokemons = new HashSet<Pokemon>();
        }

        [Key]
        [Column("idTypes")]
        public int IdTypes { get; set; }
        [Column("nomTypes")]
        [StringLength(255)]
        [Unicode(false)]
        public string NomTypes { get; set; } = null!;

        [InverseProperty("IdTypesNavigation")]
        public virtual ICollection<Pokemon> Pokemons { get; set; }
    }
}
