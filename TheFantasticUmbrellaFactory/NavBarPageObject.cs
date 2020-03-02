using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TheFantasticUmbrellaFactory
{
    public class NavBarPageObject
    {
        private IWebDriver driver;
        public NavBarPageObject(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/section/nav/ul/li[1]")]
        public IWebElement BtnClients { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[href = 'insertclient_identification.html']")]
        public IWebElement BtnInsert { get; set; }

        public ClientsPageObject clickInsert()
        {
            BtnClients.Click();
            BtnInsert.Click();


            return new ClientsPageObject(driver);
        }
    }
}