using OrdinaMTech.Cv.Data.Enums;
using OrdinaMTech.Cv.Data.Models;

namespace OrdinaMTech.Cv.Data
{
    public static class DbInitializer
    {
        public static void Initialize(CvContext context)
        {
            context.Database.EnsureCreated();
            var cv = context.Cvs.FirstOrDefault();
            if (cv == null)
            {
                cv = new Models.Cv
                {
                    Personalia = new Personalia()
                    {
                        Naam = "Denise Oostdam",
                        Geboortedatum = new DateTime(1995, 1, 13),
                        Hobbies = "Gamen, tafeltennis",
                        Woonplaats = "Utrecht",
                        Foto = System.IO.File.ReadAllBytes("pasfoto.png")
                    },

                    Opleidingen =
                    [
                        new Opleiding { School = "St. Gregorius College Utrecht", Niveau = "VWO", Diploma = true, DatumVan = new DateTime(2007, 9, 1), DatumTm = new DateTime(2013, 6, 1) },
                        new Opleiding { School = "Hogeschool Utrecht Informatica", Niveau = "HBO", Diploma = true, DatumVan = new DateTime(2013, 9, 1), DatumTm = new DateTime(2018, 3, 1) }
                    ],

                    Cursussen =
                    [
                        new Cursus { Naam = "AZ-203 Developing Solutions for Microsot Azure", Instituut = "Microsoft", Certificaat = true, Datum = new DateTime(2020, 1, 24) },
                        new Cursus { Naam = "Scrum Foundation", Instituut = "Scrum.org", Certificaat = true, Datum = new DateTime(2019, 5, 15) }
                    ],

                    Werkervaring =
                    [
                        new Ervaring { Functie = "Stagiaire", Project = "Interne CV applicatie", Beschrijving = "Ontwerp en bouw van een interne CV application in .NET Core en ReactJS.", Organisatie = "FutureTech", DatumVan = new DateTime(2017, 9, 1), DatumTm = new DateTime(2018, 1, 31) },
                        new Ervaring { Functie = "Junior .NET developer", Project = "Interne CV applicatie", Beschrijving = "Ontwerp en bouw van een interne CV applicatie in Azure", Organisatie = "MTech", DatumVan = new DateTime(2018, 4, 1), DatumTm = null }
                    ],

                    Talen =
                    [
                        new Taal() { Naam = "Nederlands", Mondeling = Taalniveau.Excellent, Schriftelijk = Taalniveau.Excellent },
                        new Taal() { Naam = "Engels", Mondeling = Taalniveau.Goed, Schriftelijk = Taalniveau.Goed }
                    ],

                    Kennis =
                    [
                        new Kennis() { Kennisgebied = "Scrum", Jaren = 2, Kennisniveau = Kennisniveau.Gemiddeld },
                        new Kennis() { Kennisgebied = "C#", Jaren = 3, Kennisniveau = Kennisniveau.Ervaren },
                        new Kennis() { Kennisgebied = "ReactJS", Jaren = 1, Kennisniveau = Kennisniveau.Basiskennis },
                        new Kennis() { Kennisgebied = "Azure", Jaren = 2, Kennisniveau = Kennisniveau.Gemiddeld }
                    ]
                };
                context.Cvs.Add(cv);
                context.SaveChanges();
            }
        }
    }
}