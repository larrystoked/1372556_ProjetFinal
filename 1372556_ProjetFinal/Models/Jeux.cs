using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _1372556_ProjetFinal.Models
{
    [Table("Jeux")]
    public partial class Jeux
    {
        [Key]
        [Column("idJeux")]
        public int IdJeux { get; set; }
        [Column("nomJeu")]
        [StringLength(255)]
        [Unicode(false)]
        public string NomJeu { get; set; } = null!;
        [Column("dateSortie", TypeName = "date")]
        public DateTime? DateSortie { get; set; }
        [Column("age")]
        public int? Age { get; set; }
        [Column("idGeneration")]
        public int? IdGeneration { get; set; }

        [ForeignKey("IdGeneration")]
        [InverseProperty("Jeuxes")]
        public virtual Generation? IdGenerationNavigation { get; set; }
    }
}
