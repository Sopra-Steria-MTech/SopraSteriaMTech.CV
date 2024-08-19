

namespace OrdinaMTech.Cv.WebApi.Services
{
    public interface ICvService
    {
        Data.Models.Cv? GetCv();
        void RemoveAllCvs();
        void Update(Data.Models.Cv cv);
    }
}
