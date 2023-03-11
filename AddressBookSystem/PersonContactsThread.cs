using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class PersonContactsThread
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zipcode { get; set; }
        public long phoneNumber { get; set; }
        public string email { get; set; }
        public DateTime StartDate { get; set; }
      
        public PersonContactsThread(string firstName, string lastName, string address, string city, int zipcode, long phoneNumber, string email, string startDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.zipcode = zipcode;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.StartDate = StartDate;
        }
    }
}
