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


        public void FillAddresMainForm(string zipCodMain, string addressMain, string numberMain, string cityMain, string stateMain, string foneMain, string mobileMain)
        {
            TextzipCodMain.SendKeys(zipCodMain);
            TextaddressMain.SendKeys(addressMain);
            TextNumberMain.SendKeys(numberMain);
            TextcityMain.SendKeys(cityMain);
            TextstateMain.SendKeys(stateMain);
            TextfoneMain.SendKeys(foneMain);
            TextmobileMain.SendKeys(mobileMain);
        }

        public void FillAddresBillingForm(string zipCodBilling, string addressBilling, string numberBilling, string cityBilling, string stateBilling, string foneBilling, string mobileBilling)
        {
            TextZipCodeBilling.SendKeys(zipCodBilling);
            TextAdmAdresBilling.SendKeys(addressBilling);
            TextAddNumberBilling.SendKeys(numberBilling);
            TextAddCityBilling.SendKeys(cityBilling);
            TextAddStateBilling.SendKeys(stateBilling);
            TextAddPhoneBilling.SendKeys(foneBilling);
            TextAddMobileBilling.SendKeys(mobileBilling);

            btnSave.Click();

        }
    }
}
