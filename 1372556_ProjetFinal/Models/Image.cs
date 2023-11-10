using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _1372556_ProjetFinal.Models
{
    [Table("Image")]
    [Index("Identifiant", Name = "UC_Image_Identifiant", IsUnique = true)]
    public partial class Image
    {
        [Key]
        public int Id { get; set; }
        public Guid Identifiant { get; set; }
        public byte[]? FichierImage { get; set; }
    }
}
