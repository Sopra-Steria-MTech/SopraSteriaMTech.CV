<<<<<<< HEAD:SopraSteriaMTech.Cv.WebApi/Services/ICvService.cs
﻿namespace SopraSteriaMTech.Cv.WebApi.Services
=======
﻿namespace OrdinaMTech.Cv.WebApi.Services
>>>>>>> master:OrdinaMTech.Cv.WebApi/Services/ICvService.cs
{
    public interface ICvService
    {
        Data.Models.Cv? GetCv();
        void RemoveAllCvs();
        void Update(Data.Models.Cv cv);
        void Reset();
    }
}
