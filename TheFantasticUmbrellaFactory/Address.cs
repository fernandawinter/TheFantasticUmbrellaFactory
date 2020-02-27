using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFantasticUmbrellaFactory
{
    public class Address
    {
        private string street;
        private string zipCode;
        private string number;
        private string state;
        private string city;
        private string mobileNumber;
        private string phoneNumber;

        public Address()
        {

        }

        public string getStreet()
        {
            return this.street = "Rua A";
        }

        public string getNumber()
        {
            return this.number = "12";
        }

        public string getCity()
        {
            return this.city = "Porto Alegre";
        }

        public string getState()
        {
            return this.state = "CA";
        }

        public string getZipCode()
        {
            return this.zipCode = "52466";
        }

        public string getMobileNumber()
        {
            return this.mobileNumber = "51991353795";
        }

        public string getPhoneNumber()
        {
            return this.phoneNumber = "51991353795";
        }
    }
}
