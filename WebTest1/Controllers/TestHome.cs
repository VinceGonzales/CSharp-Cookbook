using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Models;
using WebApplication1.Controllers;
using Moq;
using System.Web.Mvc;
using System.Web.Routing;
using WebApplication1;

namespace WebTest1.Controllers
{
    [TestClass]
    public class TestHome
    {
        private HomeController _controller;
        private Mock<IRepository> mockRepository;

        [TestInitialize]
        public void InitializeTest()
        {
            mockRepository = new Mock<IRepository>();
            _controller = new HomeController(mockRepository.Object);
        }

        [TestMethod]
        public void Home_Should_Display_Index_Page()
        {
            // Arrange
            RouteTable.Routes.Clear();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            var httpContext = MvcMockHelpers.MockHttpContext(@"~/");
            var routeData = RouteTable.Routes.GetRouteData(httpContext);
            _controller.SetMockControllerContext(httpContext, routeData, RouteTable.Routes);

            // Act
            ViewResult result = _controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(ActionResult));
        }
    }
}
