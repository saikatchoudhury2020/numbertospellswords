using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using convertnumbertospellswords;
using convertnumbertospellswords.Controllers;

namespace convertnumbertospellswords.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void IndexWithDigits()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            string digits = "12345";
            ViewResult result = controller.Index(digits) as ViewResult;

            // Assert
            Assert.AreEqual(result.ViewBag.Name, "Twelve Thousand Three Hundred Fourty Five  Only");
        }

        [TestMethod]
        public void IndexWithDigits0()
        {
            // Arrange
            HomeController controller = new HomeController();
           
           string digits = "0";
            ViewResult result = controller.Index(digits) as ViewResult;
            Assert.AreEqual(result.ViewBag.Name, "The number in currency format is Zero Only");
        }
        [TestMethod]
        public void IndexWithDigitsMinus()
        {
            // Arrange
            HomeController controller = new HomeController(); 
            string digits = "-12340";
            ViewResult result = controller.Index(digits) as ViewResult;
            Assert.AreEqual(result.ViewBag.Name, "Minus Twelve Thousand Three Hundred Fourty  Only");
        }
        [TestMethod]
        public void IndexWithDigitsPaisa()
        {
            // Arrange
            HomeController controller = new HomeController();
            string digits = "67.98";
            ViewResult result = controller.Index(digits) as ViewResult;
            Assert.AreEqual(result.ViewBag.Name, "Sixty Seven and Nine Eight Paisa Only");
            
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
