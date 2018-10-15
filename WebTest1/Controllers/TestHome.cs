using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Models;
using WebApplication1.Controllers;
using Moq;
using System.Web.Mvc;

namespace WebTest1.Controllers
{
    [TestClass]
    public class TestHome
    {
        [TestMethod]
        public void Home_Should_Display_Index_Page()
        {
            // Arrange
            Mock<IRepository> mockRepo = new Mock<IRepository>();
            HomeController controller = new HomeController(mockRepo.Object);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(ActionResult));
        }
    }
}
