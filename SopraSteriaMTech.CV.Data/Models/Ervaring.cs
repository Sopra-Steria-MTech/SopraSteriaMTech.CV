﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SopraSteriaMTech.Cv.Data.Models
{
    public class Ervaring
    {
        public int Id { get; set; }
        public DateTime DatumVan { get; set; }
        public DateTime? DatumTm { get; set; }
        public string? Organisatie { get; set; }
        public string? Functie { get; set; }
        [Required]
        public string? Project { get; set; }
        [Required]
        public string? Beschrijving { get; set; }

        [ForeignKey("Cv")]
        public int CvId { get; set; }
    }
}