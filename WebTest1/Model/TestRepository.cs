using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Models;

namespace WebTest1.Model
{
    [TestClass]
    public class TestRepository
    {
        [TestMethod]
        public void GetStates_Should_Return_String_List()
        {
            // Arrange
            Repository repo = new Repository("DefaultConnectionString");

            // Act
            var result = repo.GetStates();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(string[]));
            Assert.IsTrue((result as string[]).Count() > 0);
        }
        [TestMethod]
        public void GetStreetDirection_Should_Return_String_List()
        {
            // Arrange
            Repository repo = new Repository("DefaultConnectionString");

            // Act
            var result = repo.GetStreetDirection();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(string[]));
            Assert.IsTrue((result as string[]).Count() > 0);
        }
        [TestMethod]
        public void GetStreetSuffix_Should_Return_String_List()
        {
            // Arrange
            Repository repo = new Repository("DefaultConnectionString");

            // Act
            var result = repo.GetStreetSuffix();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(string[]));
            Assert.IsTrue((result as string[]).Count() > 0);
        }
    }
}
