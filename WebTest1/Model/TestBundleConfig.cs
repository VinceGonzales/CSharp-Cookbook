using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Optimization;
using WebApplication1;

namespace WebTest1.Model
{
    [TestClass]
    public class TestBundleConfig
    {
        [TestInitialize]
        public void InitializeTest()
        {
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        [TestMethod]
        public void BundleConfig_Should_Return_Bundle()
        {
            // Arrange
            List<Bundle> _bundles = BundleTable.Bundles.GetRegisteredBundles().ToList();

            // Act
            StyleBundle result1 = _bundles.First(x => x.Path == "~/Content/css") as StyleBundle;
            ScriptBundle result2 = _bundles.First(x => x.Path == "~/bundles/jquery") as ScriptBundle;

            // Assert
            Assert.IsNotNull(result1);
            Assert.IsNotNull(result2);
        }
    }
}
