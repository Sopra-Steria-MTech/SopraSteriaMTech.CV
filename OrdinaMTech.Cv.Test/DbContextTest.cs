using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrdinaMTech.Cv.Api.Controllers;
using OrdinaMTech.Cv.Data;
using System.IO;
using System.Threading.Tasks;
using SixLabors.ImageSharp;

namespace OrdinaMTech.Cv.Test
{
    [TestClass]
    public class DbContextTest
    {
        private CvContext _dbContext;

        [TestInitialize]
        public void Initialize()
        {
            var options = new DbContextOptionsBuilder<CvContext>()
                .UseInMemoryDatabase("CvTest")
                .Options;
            _dbContext = new CvContext(options);
            _dbContext.Database.EnsureDeleted();
            _dbContext.Database.EnsureCreated();

            var cvControler = new CvController(null, _dbContext);
            cvControler.Put();
        }

        [TestMethod]
        public async Task TestUploadFotoAsync()
        {
            // Arrange
            var cvControler = new CvController(null, _dbContext);
            var foto = File.ReadAllBytes("pasfoto.png");
            var stream = new MemoryStream(foto);
            var file = new FormFile(stream, 0, foto.Length, "pasfoto", "pasfoto.png");

            // Act
            cvControler.Upload(file);

            // Assert
            var cv = await _dbContext.Cvs.FirstOrDefaultAsync();
            var result = cv.Personalia.Foto;
            using var image = Image.Load(result);
            Assert.AreEqual(300, image.Width);
            Assert.AreEqual(300, image.Height);
        }
    }
}
