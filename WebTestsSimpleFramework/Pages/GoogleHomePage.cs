using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace WebTestsSimpleFramework.Pages
{
    public class GoogleHomePage
    {
        public GoogleHomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "lst-ib")]
        private IWebElement searchField;

        [FindsBy(How = How.Name, Using = "btnK")]
        private IWebElement startSearchButton;

        public GoogleHomePage ClickSearchField()
        {
            searchField.Click();
            return this;
        }

        public GoogleHomePage WriteTextInSearchField(string text)
        {
            searchField.SendKeys(text);
            return this;
        }

        public GoogleHomePage ClickSearchButton()
        {
            startSearchButton.Submit();
            return this;
        }
    }
}
