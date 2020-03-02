using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFantasticUmbrellaFactory
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPromoCodePerson()
        {
            ChromeOptions options = new ChromeOptions();

            options.AddArguments("--user-data-dir=C:/Users/fernanda.winter/AppData/Local/Google/Chrome/User Data");

            ChromeDriver driver = new ChromeDriver(options);

            driver.Url = "file:///C:/Users/fernanda.winter/Desktop/Version%202/index.html";

            driver.Manage().Timeouts().ImplicitWait.TotalSeconds.Equals(60);

            HeaderPageObject headerPageObject = new HeaderPageObject(driver);

            NavBarPageObject navBarPageObject = headerPageObject.Login("paul", "paul");

            

            ClientsPageObject formPageObject = navBarPageObject.clickInsert();

            formPageObject.preencherClientType("Person");
            formPageObject.preencherPromoCode();
            formPageObject.preencherEmail("fernanda@company.com");
            formPageObject.preencherName("Fernanda Company");
            formPageObject.preencherBirthDate("23081995");
            formPageObject.preencherGender("Female");
            formPageObject.preencherMaritalStatus("not Facebook official");

            AddressPageObject addressPageObject = formPageObject.ApertaBtnNext();

            Address address = new Address();

            addressPageObject.FillAddressMainForm(address);

            addressPageObject.FillAddressBillingForm(address);

            addressPageObject.VerifySuccessMessage();
        }

        [TestMethod]
        public void TestPromoCodeCompany()
        {
            ChromeOptions options = new ChromeOptions();

            options.AddArguments("--user-data-dir=C:/Users/fernanda.winter/AppData/Local/Google/Chrome/User Data/");

            ChromeDriver driver = new ChromeDriver(options);

            driver.Url = "file:///C:/Users/fernanda.winter/Desktop/Version%202/index.html";

            HeaderPageObject hearderPageObject = new HeaderPageObject(driver);


            NavBarPageObject navBarPageObject = hearderPageObject.Login("paul", "paul");

            ClientsPageObject formPageObject = navBarPageObject.clickInsert();

            formPageObject.preencherClientType("Company");
            formPageObject.preencherPromoCode();
            formPageObject.preencherEmail("fernanda@company.com");
            formPageObject.preencherName("Fernanda Company");

            AddressPageObject addressPageObject = formPageObject.ApertaBtnNext();

            Address address = new Address();

            addressPageObject.FillAddressMainForm(address);

            addressPageObject.FillAddressBillingForm(address);

            addressPageObject.VerifySuccessMessage();
        }

        [TestMethod]
        public void TestPromoCodeCompanyCNPJInvalido()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--user-data-dir=C:/Users/fernanda.winter/AppData/Local/Google/Chrome/User Data/");
            ChromeDriver driver = new ChromeDriver(options);
            driver.Url = "file:///C:/Users/fernanda.winter/Desktop/Version%202/index.html";

            HeaderPageObject hearderPageObject = new HeaderPageObject(driver);

            NavBarPageObject navBarPageObject = hearderPageObject.Login("paul", "paul");

            ClientsPageObject formPageObject = navBarPageObject.clickInsert();

            formPageObject.preencherClientType("Company");
            formPageObject.TextPromoCode.SendKeys("00000000");
            driver.FindElement(By.Id("name_companyname")).Click();
            IAlert alert = driver.SwitchTo().Alert();
            if (alert != null)
            {
                string alertText = alert.Text;
                Assert.AreEqual("Invalid Promotional Code", alertText);
                alert.Accept();
                driver.Quit();
            }
        }

        [TestMethod]
        public void TestPromoCodePersonCPFInvalido()
        {
            ChromeOptions options = new ChromeOptions();

            options.AddArguments("--user-data-dir=C:/Users/fernanda.winter/AppData/Local/Google/Chrome/User Data/");

            ChromeDriver driver = new ChromeDriver(options);

            driver.Url = "file:///C:/Users/fernanda.winter/Desktop/Version%202/index.html";

            driver.Manage().Timeouts().ImplicitWait.TotalSeconds.Equals(60);

            HeaderPageObject hearderPageObject = new HeaderPageObject(driver);

            NavBarPageObject navBarPageObject = hearderPageObject.Login("paul", "paul");

            ClientsPageObject formPageObject = navBarPageObject.clickInsert();

            formPageObject.preencherClientType("Person");
            formPageObject.TextPromoCode.SendKeys("00000000");
            driver.FindElement(By.Id("name_companyname")).Click();
            IAlert alert = driver.SwitchTo().Alert();
            if (alert != null)
            {
                string alertText = alert.Text;
                Assert.AreEqual("Invalid Promotional Code", alertText);
                alert.Accept();
                driver.Quit();
            }
        }
    }
}
