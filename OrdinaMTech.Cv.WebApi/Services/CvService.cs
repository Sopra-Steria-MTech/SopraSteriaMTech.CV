using Microsoft.EntityFrameworkCore;
using OrdinaMTech.Cv.Data;

namespace OrdinaMTech.Cv.WebApi.Services
{
    public class CvService(CvContext cvContext) : ICvService
    {
        private readonly CvContext _cvContext = cvContext;

        public Data.Models.Cv? GetCv()
        {
            return _cvContext.Cvs.FirstOrDefault();
        }

        public void RemoveAllCvs()
        {
            var cvs = _cvContext.Cvs
                .Include(c => c.Kennis)
                .Include(c => c.Cursussen)
                .Include(c => c.Personalia)
                .Include(c => c.Talen)
                .Include(c => c.Werkervaring)
                .Include(c => c.Opleidingen);
            _cvContext.RemoveRange(cvs);
        }

        public void Update(Data.Models.Cv cv)
        {
            _cvContext.Update(cv);
            _cvContext.SaveChanges();
        }
    }
}
