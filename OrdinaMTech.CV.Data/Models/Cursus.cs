﻿using System.ComponentModel.DataAnnotations.Schema;

namespace OrdinaMTech.Cv.Data.Models
{
    public class Cursus
    {
        public int Id { get; set; }
        public string? Naam { get; set; }
        public string? Instituut { get; set; }
        public DateTime Datum { get; set; }
        public bool? Certificaat { get; set; }

        [ForeignKey("Cv")]
        public int CvId { get; set; }
    }
}