using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
<<<<<<< HEAD:SopraSteriaMTech.Cv.Test/CvControllerTests.cs
using SopraSteriaMTech.Cv.Api.Controllers;
using SopraSteriaMTech.Cv.WebApi.Services;
=======
using OrdinaMTech.Cv.Api.Controllers;
using OrdinaMTech.Cv.WebApi.Services;
>>>>>>> master:OrdinaMTech.Cv.Test/CvControllerTests.cs
using System.Net;

namespace SopraSteriaMTech.Cv.Test
{
    [TestClass]
    public class CvControllerTests
    {
        [TestMethod]
        public void GettingBasePageReturnsHttpStatusOk()
        {
            // Arrange
            var mockedCvService = new Mock<ICvService>();
            mockedCvService.Setup(s => s.GetCv()).Returns(new Data.Models.Cv());

            var controller = new CvController(mockedCvService.Object);

            // Act
            var response = controller.Get() as OkObjectResult;

            // Assert
            Assert.AreEqual((int)HttpStatusCode.OK, response.StatusCode);
        }
    }
}
