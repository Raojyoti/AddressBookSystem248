using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AddressBookSystem
{
    public class AddressBookMain
    {
        public static List<Contacts> Person = new List<Contacts>();
        public static Dictionary<string, List<Contacts>> dictionarybook = new Dictionary<string, List<Contacts>>();
        //UC2- Add Contact to Address Book
        public static void AddContacts()
        {
            Console.Clear();
            Contacts contact = new Contacts();
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
            contact.zipcode = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter phone number: ");
            contact.phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.Write("Please enter email id:  ");
            contact.email = Console.ReadLine();
            Person.Add(contact);
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadLine();
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
        //UC3-Edit existing contact person using their name.
        public static void EditPersonDetails()
        {
            Console.Clear();
            Console.WriteLine("Enter First Name of the person you want to edit: ");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter Last Name of the person you want to edit: ");
            string lName = Console.ReadLine();
            foreach (var data in Person)
            {
                if (Person.Contains(data))
                {
                    if (data.firstName.ToLower().Equals(fName.ToLower()) || data.lastName.ToLower().Equals(lName.ToLower()))
                    {
                        Console.WriteLine("Please select option whivh you want to edit :-- \n 1.FirstName and LastName\n 2.Address\n 3.City\n 4.State\n 5.Zipcode\n 6.PhoneNumber\n");
                        int option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                Console.WriteLine("Enter New First Name : ");
                                string firstName = Console.ReadLine();
                                data.firstName = firstName;
                                Console.WriteLine("Enter New Last Name : ");
                                string lastName = Console.ReadLine();
                                data.lastName = lastName;
                                break;
                            case 2:
                                Console.WriteLine("Enter New Address : ");
                                string address = Console.ReadLine();
                                data.address = address;
                                break;
                            case 3:
                                Console.WriteLine("Enter City : ");
                                string city = Console.ReadLine();
                                data.city = city;
                                break;
                            case 4:
                                Console.WriteLine("Enter New State : ");
                                string state = Console.ReadLine();
                                data.state = state;
                                break;
                            case 5:
                                Console.WriteLine("Enter New Zip Code : ");
                                int zipCode = Convert.ToInt32(Console.ReadLine());
                                data.zipcode = zipCode;
                                break;
                            case 6:
                                Console.WriteLine("Enter New Phone Number : ");
                                int phonenumber = Convert.ToInt32(Console.ReadLine());
                                data.phoneNumber = phonenumber;
                                break;
                            default:
                                Console.WriteLine("Select Valid option ");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Name does not match");
                        Console.ReadLine();
                    }
                }
            }
        }
        //UC4-Delete a person using person's name
        public static void DeletePersonByUsingPersonName()
        {
            Console.Clear();
            Console.WriteLine("Enter the first name of that person you want to remove: ");
            string fName = Console.ReadLine();
            foreach (var data in Person)
            {
                if (data.firstName.ToLower() == fName.ToLower())
                {
                    Person.Remove(data);
                    Console.WriteLine("{0} is deleted sucessfully from the AddressBook\nPress any key to continue", data.firstName);
                    Console.ReadLine();
                    return;
                }
            }
        }
        //UC5- Ability to add multiple person to Address Book.
        public static void AddMultiplePerson()
        {
            Console.Clear();
            Console.WriteLine("Please enter number of person add in Contact");
            int numberPerson=Convert.ToInt32(Console.ReadLine());
            while (numberPerson > 0)
            {
                AddContacts();
                numberPerson--;
            }
        }
        //UC6- Refactor to add multiple Address Book to the System.Each Address Book has a unique Name
        public static void CreateDictionaryContacts()
        {
            Console.Clear();
            Console.WriteLine("Enter name which you want to give their new address book");
            string name = Console.ReadLine();//key 
            Console.WriteLine("Please enter number of person add in Contact");
            int numberPerson = Convert.ToInt32(Console.ReadLine());
            while (numberPerson > 0)
            {
                AddContacts();
                numberPerson--;
            }
            dictionarybook.Add(name, Person.ToList());
        }
        public static void DisplayDictionaryList()
        {
            Console.Clear();
            if (Person.Count == 0)
            {
                Console.WriteLine("**********----Your address book is empty----*********.\n Press any key to continue.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Here are the current people in your address book:\n----------------------------------------------");
            foreach (var data in dictionarybook)
            {
                Console.WriteLine(data.Key);//printing dictionary keys
                Console.WriteLine("-------------------------------------------");
                foreach (var item in data.Value)//printing dictionary values
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
            }
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
        //UC7- Ability to ensure there is no duplicate Entry of the same Person in Address Book.
        public static List<Contacts> FindPersonByName()
        {
            Console.Clear();
            Console.WriteLine("Enter person first name:");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter person last name:");
            string lName = Console.ReadLine();
            return Person.Where(x => x.firstName.ToLower() == fName.ToLower() && x.lastName.ToLower() == lName.ToLower()).ToList();
        }
        public static void CheckDuplicateEntryOfSamePersonByName()
        {
            List<Contacts> contacts = FindPersonByName();
            if (Person.Count == 0)
            {
                Console.WriteLine("That person could not be Present in Address Book");
                Console.WriteLine("Now we add that person details in Address Book\nfirst press enter and start adding details of that person");
                Console.ReadLine();
                AddContacts();
                return;
            }
            if (Person.Count == 1)
            {
                Console.WriteLine("That Person is Present in Address Book\nSo you want to see all details of that person\nJust press enter");
                Console.ReadLine();
                DisplayDetails();
                return;
            }
        }
    }
}
