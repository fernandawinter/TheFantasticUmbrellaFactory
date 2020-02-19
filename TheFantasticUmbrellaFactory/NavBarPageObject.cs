using OpenQA.Selenium;

namespace TheFantasticUmbrellaFactory
{
    internal class NavBarPageObject
    {
        private IWebDriver driver;

        public NavBarPageObject(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}