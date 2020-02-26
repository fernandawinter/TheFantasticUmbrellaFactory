using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
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

            options.AddArguments("C:/Users/fernanda.winter/AppData/Local/Google/Chrome/User Data/");
            ChromeDriver driver = new ChromeDriver(options);
            driver.Url = "file:///C:/Users/fernanda.winter/Desktop/Version%201/index.html";
            HeaderPageObject hearderPageObject = new HeaderPageObject(driver);
            NavBarPageObject navBarPageObject = hearderPageObject.Login("paul", "paul");

            FormPageObject formPageObject = navBarPageObject.ClickInsert();

            AddressPageObject addressPageObject = formPageObject.fillForm("Person", CpfUtils.GerarCpf(), "Fernanda", "fernanda@fernanda.com", "23081995", "Female", "not Facebook official");

            addressPageObject.FillAddresMainForm("51515", "Rua A", "51", "Porto Alegre", "CA", "51991353795", "33224574");

            addressPageObject.FillAddresBillingForm("51515", "Rua A", "51", "Porto Alegre", "CA", "51991353795", "33224574");

            string messege = driver.FindElementById("message").Text;

            string expected = messege.Substring(0, messege.Length - 3);
            Assert.AreEqual("Client inserted with success,", expected);

            driver.Quit();
        }
    }
}
