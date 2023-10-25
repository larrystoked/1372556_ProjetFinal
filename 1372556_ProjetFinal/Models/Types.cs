using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _1372556_ProjetFinal.Models
{
    [Table("Type")]
    [Index("NomType", Name = "UQ__Type__C90762B7BEDFB1CC", IsUnique = true)]
    public partial class Types
    {
        public Types()
        {
            IdPokemons = new HashSet<Pokemon>();
        }

        [Key]
        [Column("idType")]
        public int IdTypes { get; set; }
        [Column("nomType")]
        [StringLength(255)]
        [Unicode(false)]
        public string NomType { get; set; } = null!;

        [ForeignKey("IdType")]
        [InverseProperty("IdTypes")]
        public virtual ICollection<Pokemon> IdPokemons { get; set; }
    }
}
