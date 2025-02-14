using System.ComponentModel.DataAnnotations.Schema;

<<<<<<< HEAD:SopraSteriaMTech.CV.Data/Models/Cursus.cs
namespace SopraSteriaMTech.Cv.Data.Models
=======
namespace OrdinaMTech.Cv.Data.Models
>>>>>>> master:OrdinaMTech.CV.Data/Models/Cursus.cs
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