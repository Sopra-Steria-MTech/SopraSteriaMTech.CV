<<<<<<< HEAD:SopraSteriaMTech.CV.Data/DbInitializer.cs
﻿namespace SopraSteriaMTech.Cv.Data
=======
﻿namespace OrdinaMTech.Cv.Data
>>>>>>> master:OrdinaMTech.CV.Data/DbInitializer.cs
{
    public static class DbInitializer
    {
        public static void Initialize(CvContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}