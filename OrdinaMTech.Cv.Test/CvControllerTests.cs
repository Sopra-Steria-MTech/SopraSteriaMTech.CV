using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OrdinaMTech.Cv.Api.Controllers;
using OrdinaMTech.Cv.Data;
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
            var mockedLogger = new Mock<ILogger<CvController>>();
            var mockedCvContext = new Mock<CvContext>();
            var controller = new CvController(mockedLogger.Object, mockedCvContext.Object);

            // Act
            var response = controller.Get() as OkObjectResult;

            // Assert
            Assert.AreEqual((int)HttpStatusCode.OK, response.StatusCode);
        }
    }
}
