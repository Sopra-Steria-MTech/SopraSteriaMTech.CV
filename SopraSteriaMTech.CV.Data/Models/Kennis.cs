﻿using SopraSteriaMTech.Cv.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SopraSteriaMTech.Cv.Data.Models
{
    public class Kennis
    {
        public int Id { get; set; }
        [Required]
        public string? Kennisgebied { get; set; }
        public Kennisniveau Kennisniveau { get; set; }
        public int Jaren { get; set; }

        [ForeignKey("Cv")]
        public int CvId { get; set; }
    }
}
