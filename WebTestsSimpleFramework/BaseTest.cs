using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebTestsSimpleFramework.Pages;
using System.IO;

namespace WebTestsSimpleFramework
{
    public class BaseTest
    {
        static IWebDriver driver = new ChromeDriver(Path.GetDirectoryName("\\Driver"));
        const string homePageUrl = "https://google.com/";
        public GoogleHomePage _googleHomePage = new GoogleHomePage(driver);

        [SetUp]
        public void SetUp()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl(homePageUrl);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
