using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        private static readonly string DriverDirectory = "C:\\seleniumDriver"; // Path til den mappe, hvor du har lagt den driver du bruger
        private static IWebDriver _driver;  // Initializere din driver

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
           // _driver = new FirefoxDriver(DriverDirectory); // Sætter din driver til at være den du bruger, i dette tilfælde firefox
            _driver = new ChromeDriver(DriverDirectory); // Chrome
        }

        [ClassCleanup]
        public static void TearDown()
        {
            _driver.Dispose();  // Lukker browser og det, når testen er kørt
        }
        [TestMethod]
        public void TestMethod1()
        {
            _driver.Navigate().GoToUrl("http://localhost:3000/");  // Navigerer hen til den side du vil teste
            String title = _driver.Title;  
            Assert.AreEqual("CD APP", title);   // Tester på om titlen på din hjemmeside er det samme som det du forventer

            IWebElement buttonElement = _driver.FindElement(By.Id("GetAllButton"));  // Leder efter en knap med den Id du skriver
            buttonElement.Click(); // Klikker på den knap

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10)); // Programmet venter 10 sek på et svar, før end den failer
            IWebElement cdliste = wait.Until(c => c.FindElement(By.Id("cdliste"))); // Vener på at den har fundet det element du søger efter
            Assert.IsTrue(cdliste.Text.Contains("xx"));  // Tjekker om der er rigtigt at den indeholder noget i listen
        }
    }
}
