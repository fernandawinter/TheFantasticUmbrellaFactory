using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFantasticUmbrellaFactory
{
    class HeaderPageObject
    {
        private IWebDriver driver;
        public HeaderPageObject(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "login")]
        public IWebElement TextLogin { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement TextPassword { get; set; }

        [FindsBy(How = How.Id, Using = "btnLogin")]
        public IWebElement btnLogin { get; set; }


        public NavBarPageObject Login(String userName, String password)
        {
            TextLogin.SendKeys(userName);

            TextPassword.SendKeys(password);

            btnLogin.Click();
            System.Threading.Thread.Sleep(30000);
            return new NavBarPageObject(driver);
        }
    }
}
