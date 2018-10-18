using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Models;
using Moq;
using ORM;
using System.Configuration;
using ORM.ADO;
using BusinessObjects;
using System.Collections.Generic;

namespace WebTest1.Model
{
    [TestClass]
    public class TestRepository
    {
        private Mock<IGenericContext> db;

        [TestInitialize]
        public void InitializeTest()
        {
            db = new Mock<IGenericContext>();
        }

        [TestMethod]
        public void GetHeroes_Should_Return_Hero_List()
        {
            // Arrange
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString;
            IGenericContext db = new JusticeLeague(connectionString);
            Repository repo = new Repository(db);

            // Act
            List<IHero> sut = repo.GetHeroes();

            // Assert
            Assert.IsNotNull(sut);
            Assert.IsInstanceOfType(sut, typeof(List<IHero>));
        }
        [TestMethod]
        public void GetHero_Should_Return_Hero()
        {
            // Arrange
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString;
            IGenericContext db = new JusticeLeague(connectionString);
            Repository repo = new Repository(db);

            // Act
            IHero sut = repo.GetHero(1);

            // Assert
            Assert.IsNotNull(sut);
            Assert.IsNotNull(sut.Id);
            Assert.IsNotNull(sut.Name);
            Assert.IsNotNull(sut.Stars);
            Assert.IsNotNull(sut.Level);
            Assert.IsNotNull(sut.Description);
            Assert.IsNotNull(sut.HeroClass);
            Assert.IsInstanceOfType(sut, typeof(IHero));
        }
        [TestMethod]
        public void GetHero_Should_Return_Null()
        {
            // Arrange
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString;
            IGenericContext db = new JusticeLeague(connectionString);
            Repository repo = new Repository(db);

            // Act
            IHero sut = repo.GetHero(0);

            // Assert
            Assert.IsNull(sut);
        }
        [TestMethod]
        public void GetStates_Should_Return_String_List()
        {
            // Arrange
            Repository repo = new Repository(db.Object);

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
            Repository repo = new Repository(db.Object);

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
            Repository repo = new Repository(db.Object);

            // Act
            var result = repo.GetStreetSuffix();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(string[]));
            Assert.IsTrue((result as string[]).Count() > 0);
        }
    }
}
