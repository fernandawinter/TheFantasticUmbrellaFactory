using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFantasticUmbrellaFactory
{
    public class AddressPageObject
    {
        private IWebDriver driver;
        public AddressPageObject(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "addm_zipcode")]
        public IWebElement TextzipCodMain { get; set; }

        [FindsBy(How = How.Id, Using = "addm_address")]
        public IWebElement TextaddressMain { get; set; }

        [FindsBy(How = How.Id, Using = "addm_number")]
        public IWebElement TextNumberMain { get; set; }

        [FindsBy(How = How.Id, Using = "addm_city")]
        public IWebElement TextcityMain { get; set; }

        [FindsBy(How = How.Id, Using = "addm_state")]
        public IWebElement TextstateMain { get; set; }

        [FindsBy(How = How.Id, Using = "addm_phone")]
        public IWebElement TextfoneMain { get; set; }

        [FindsBy(How = How.Id, Using = "addm_mobile")]
        public IWebElement TextmobileMain { get; set; }

        // BILL ADDRES

        [FindsBy(How = How.Id, Using = "addb_zipcode")]
        public IWebElement TextZipCodeBilling { get; set; }

        [FindsBy(How = How.Id, Using = "addb_address")]
        public IWebElement TextAdmAdresBilling { get; set; }

        [FindsBy(How = How.Id, Using = "addb_number")]
        public IWebElement TextAddNumberBilling { get; set; }

        [FindsBy(How = How.Id, Using = "addb_city")]
        public IWebElement TextAddCityBilling { get; set; }

        [FindsBy(How = How.Id, Using = "addb_state")]
        public IWebElement TextAddStateBilling { get; set; }

        [FindsBy(How = How.Id, Using = "addb_phone")]
        public IWebElement TextAddPhoneBilling { get; set; }

        [FindsBy(How = How.Id, Using = "addb_mobile")]
        public IWebElement TextAddMobileBilling { get; set; }

        [FindsBy(How = How.Id, Using = "back")]
        public IWebElement btnBack { get; set; }

        [FindsBy(How = How.Id, Using = "save")]
        public IWebElement btnSave { get; set; }

        [FindsBy(How = How.Id, Using = "message")]
        public IWebElement textMessage { get; set; }


        public void FillAddressBillingForm(Address address)
        {
            TextZipCodeBilling.SendKeys(address.getZipCode());
            TextAdmAdresBilling.SendKeys(address.getStreet());
            TextAddNumberBilling.SendKeys(address.getNumber());
            TextAddCityBilling.SendKeys(address.getCity());
            TextAddStateBilling.SendKeys(address.getState());
            TextAddPhoneBilling.SendKeys(address.getPhoneNumber());
            TextAddMobileBilling.SendKeys(address.getMobileNumber());

            btnSave.Click();
        }

        public void FillAddressMainForm(Address address)
        {
            TextzipCodMain.SendKeys(address.getZipCode());
            TextaddressMain.SendKeys(address.getStreet());
            TextNumberMain.SendKeys(address.getNumber());
            TextcityMain.SendKeys(address.getCity());
            TextstateMain.SendKeys(address.getState());
            TextfoneMain.SendKeys(address.getPhoneNumber());
            TextmobileMain.SendKeys(address.getMobileNumber());

        }

        public void VerifySuccessMessage()
        {
            string message = textMessage.Text;

            string expected = message.Substring(0, 28);
            Assert.AreEqual("Client inserted with success", expected);

            driver.Quit();
        }
    }
}
