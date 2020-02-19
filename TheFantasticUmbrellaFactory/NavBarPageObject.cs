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

        [FindsBy(How = How.XPath, Using = "//li/a[text()='Clients']")]
        public IWebElement BtnClients { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[href = 'insertclient_identification.html']")]
        public IWebElement BtnInsert { get; set; }


        public FormPageObject clickInsert()
        {
            BtnClients.Click();
            BtnInsert.Click();


            return new FormPageObject(driver);
        }
    }
}