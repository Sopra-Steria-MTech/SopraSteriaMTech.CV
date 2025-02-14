using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OrdinaMTech.Cv.Api.Controllers;
using OrdinaMTech.Cv.WebApi.Services;
using System.Net;

namespace OrdinaMTech.Cv.Test
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
