using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFantasticUmbrellaFactory
{
    public class ClientsPageObject
    {
        private IWebDriver driver;
        public ClientsPageObject(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "form_principal")]
        public IWebElement RadioClientType { get; set; }

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

        public bool isPerson()
        {
            if (driver.FindElement(By.Id("person")).Selected)
            {
                return true;
            }
            return false;
        }

        public AddressPageObject fillForm(string clientType, string promoCode, string name, string email, string birthDate, string gender, string maritalStatus)
        {
            TextName.SendKeys(name);
            TextEmail.SendKeys(email);

            if (clientType == "Person")
            {
                RadioClientType.FindElement(By.XPath("//label[text()="+"'" +clientType+ "']")).Click();
                TextPromoCode.SendKeys(promoCode);
                TextBirthDate.SendKeys(birthDate);
                SelectGender.SendKeys(gender);
                SelectGender.FindElement(By.XPath("//select/option[text()="+"'" +maritalStatus+ "'"+"]")).Click();
                BtnNext.Click();
                return new AddressPageObject(driver);
            }
            RadioClientType.FindElement(By.XPath("//label[text()="+"'" +clientType+ "']")).Click();
            TextPromoCode.SendKeys(promoCode);
            BtnNext.Click();
            return new AddressPageObject(driver);
        }

        public void preencherClientType(String clientType)
        {
            RadioClientType.FindElement(By.XPath("//label[text()="+"'" +clientType+ "']")).Click();
        }

        public void preencherPromoCode()
        {
            if (isPerson())
                TextPromoCode.SendKeys(Utils.GerarCpf());
            else
                TextPromoCode.SendKeys(Utils.GeraCNPJ());
        }

        public void preencherName(String name)
        {
            TextName.SendKeys(name);
        }

        public void preencherEmail(String email)
        {
            TextEmail.SendKeys(email);
        }

        public void preencherBirthDate(String birthDate)
        {
            if (isPerson())
                TextBirthDate.SendKeys(birthDate);
        }

        public void preencherGender(String gender)
        {
            if (isPerson())
                SelectGender.SendKeys(gender);
        }

        public void preencherMaritalStatus(String maritalStatus)
        {
            if (isPerson())
                SelectGender.FindElement(By.XPath("//select/option[text()="+"'" +maritalStatus+ "'"+"]")).Click();
        }

        public AddressPageObject ApertaBtnNext()
        {
            BtnNext.Click();
            return new AddressPageObject(driver);
        }
    }
}
