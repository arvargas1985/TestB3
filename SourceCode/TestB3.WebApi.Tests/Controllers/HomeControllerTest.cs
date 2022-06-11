using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestB3.WebApi;
using TestB3.WebApi.Controllers;

namespace TestB3.WebApi.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Organizar
            HomeController controller = new HomeController();

            // Agir
            ViewResult result = controller.Index() as ViewResult;

            // Declarar
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
