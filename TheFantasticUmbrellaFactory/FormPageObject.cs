using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFantasticUmbrellaFactory
{
    public class FormPageObject
    {
        private IWebDriver driver;
        public FormPageObject(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "form_principal")]
        public IWebElement Radiotype { get; set; }

        [FindsBy(How = How.Id, Using = "promo_code")]
        public IWebElement TextPromoCode { get; set; }

        [FindsBy(How = How.Id, Using = "name_companyname")]
        public IWebElement TextName { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement TextEmail { get; set; }

        [FindsBy(How = How.Id, Using = "birthday_date")]
        public IWebElement TextBirthDate { get; set; }

        [FindsBy(How = How.Id, Using = "gender")]
        public IWebElement SelectGender { get; set; }

        [FindsBy(How = How.Id, Using = "marital_status")]
        public IWebElement SelectMaritalClients { get; set; }

        [FindsBy(How = How.Id, Using = "next")]
        public IWebElement BtnNext { get; set; }

        public AddressPageObject fillForm(string clientType, string promoCode, string name, string email, string birthDate, string gender, string maritalStatus)
        {
            if (clientType == "Person")
            {
                Radiotype.FindElement(By.XPath("//label[text()=" + "'" + clientType + "']")).Click();
                TextPromoCode.SendKeys(promoCode);
                TextName.SendKeys(name);
                TextEmail.SendKeys(email);
                TextBirthDate.SendKeys(birthDate);
                SelectGender.SendKeys(gender);
                SelectGender.FindElement(By.XPath("//select/option[text()=" + "'" + maritalStatus + "'" + "]")).Click();
                BtnNext.Click();
                return new AddressPageObject(driver);
            }
            Radiotype.FindElement(By.XPath("//label[text()=" + "'" + clientType + "']")).Click();
            TextPromoCode.SendKeys(promoCode);
            TextName.SendKeys(name);
            TextEmail.SendKeys(email);
            BtnNext.Click();
            return new AddressPageObject(driver);
        }
    }
}
