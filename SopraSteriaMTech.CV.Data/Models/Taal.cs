﻿using SopraSteriaMTech.Cv.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SopraSteriaMTech.Cv.Data.Models
{
    public class Taal
    {
        public int Id { get; set; }
        [Required]
        public string? Naam { get; set; }
        public Taalniveau Schriftelijk {get; set; }
        public Taalniveau Mondeling { get; set; }

        [ForeignKey("Cv")]
        public int CvId { get; set; }
    }
}
