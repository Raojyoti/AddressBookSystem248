using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBookMain
    {
        public static List<Contacts> Person = new List<Contacts>();
        //UC2- Add Contact to Address Book
        public static void AddContacts() 
        {
            Console.Clear();
            Contacts contact= new Contacts();
            Console.Write("Please enter first name:   ");
            contact.firstName = Console.ReadLine();
            Console.Write("Please enter last name:   ");
            contact.lastName = Console.ReadLine();
            Console.Write("Please enter address:   ");
            contact.address = Console.ReadLine();
            Console.Write("Please enter city name:   ");
            contact.city = Console.ReadLine();
            Console.Write("Please enter state name:   ");
            contact.state = Console.ReadLine();
            Console.Write("Please enter zip code:   ");
            contact.zipcode=Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter phone number: ");
            contact.phoneNumber= Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter email id:  ");
            contact.email = Console.ReadLine();
            Person.Add(contact);
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }
        public static void DisplayDetails()
        {
            Console.Clear();
            if (Person.Count == 0)
            {
                Console.WriteLine("**********----Your address book is empty----*********.\n Press any key to continue.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Here are the current people in your address book:\n----------------------------------------------");
            foreach (var item in Person)
            {
                Console.WriteLine("First Name: " + item.firstName);
                Console.WriteLine("Last Name: " + item.lastName);
                Console.WriteLine("City Name: " + item.city);
                Console.WriteLine("Address : " + item.address);
                Console.WriteLine("State : " + item.state);
                Console.WriteLine("Zip Code : " + item.zipcode);
                Console.WriteLine("Phone Number: " + item.phoneNumber);
                Console.WriteLine("Email Id : " + item.email);
                Console.WriteLine("-------------------------------------------");
            }
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
