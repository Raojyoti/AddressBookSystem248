using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
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
        /// <summary>
        /// UC2- Add Contact to Address Book
        /// </summary>
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
        /// <summary>
        /// UC3-Edit existing contact person using their name.
        /// </summary>
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
        /// <summary>
        /// UC4-Delete a person using person's name
        /// </summary>
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
        /// <summary>
        /// UC5- Ability to add multiple person to Address Book.
        /// </summary>
        public static void AddMultiplePerson()
        {
            Console.Clear();
            Console.WriteLine("Please enter number of person add in Contact");
            int numberPerson = Convert.ToInt32(Console.ReadLine());
            while (numberPerson > 0)
            {
                AddContacts();
                numberPerson--;
            }
        }
        /// <summary>
        /// UC6- Refactor to add multiple Address Book to the System.Each Address Book has a unique Name
        /// </summary>
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
                Console.ReadLine();
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
            Console.ReadLine();
        }
        /// <summary>
        /// UC7- Ability to ensure there is no duplicate Entry of the same Person in Address Book.
        /// </summary>
        public static void CheckDuplicateEntryOfSamePersonByName()
        {
            Console.Clear();
            Console.WriteLine("Enter first name to which you want to  check duplicate entry ");
            string name = Console.ReadLine();
            bool check = Person.Any(s => s.firstName.ToLower() == name.ToLower());
            if (check)
            {
                Console.WriteLine("contact Exists");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("In address book ==> {0} is not present \n So we add this person in contact\n just press enter and fill all details..");
                Console.ReadLine();
                AddContacts();
            }
        }
        /// <summary>
        /// UC8- Ability to search Person in a City or State across the multiple AddressBook.
        /// </summary>
        public static void SearchPersonByCityOrState()
        {
            Console.Clear();
            Console.WriteLine("First select options:--");
            Console.WriteLine("1.Search Person In City\n2.Search Person In State\n");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter that City name where want to search the person name ");
                    string cityName = Console.ReadLine();
                    Console.WriteLine("Enter person name that you want to search in City ");
                    string cityPersonName = Console.ReadLine();
                    foreach (var pair in dictionarybook.Keys)
                    {
                        Console.WriteLine("Address Book Name: " + pair);
                        foreach (var data in Person.FindAll(e => e.city.ToLower() == cityName.ToLower() && e.firstName.ToLower() == cityPersonName.ToLower()).ToList())
                        {
                            Console.WriteLine("The Contact Details of " + data.city + " are:\n--------------------------" + "\nFirstName: " + data.firstName + " " + "\nLastName: " + data.lastName + " " + "\nZipcode: " + data.zipcode + " " + "\nPhoneNumber: " + data.phoneNumber);
                            Console.WriteLine("\nPress any key to continue....");
                            Console.ReadLine();//
                            return;
                        }
                    }
                    Console.WriteLine("Person With Name ==> {0} is not found in the AddressBook in City ==> {1}", cityPersonName, cityName);
                    Console.WriteLine("\nPress any key to continue.....");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Enter that State name where want to search the person name ");
                    string stateName = Console.ReadLine();
                    Console.WriteLine("Enter person name that you want to search in State ");
                    string statePersonName = Console.ReadLine();
                    foreach (var pair in dictionarybook.Keys)
                    {
                        Console.WriteLine("Address Book Name " + pair);
                        foreach (var data in Person.FindAll(e => e.state.ToLower() == stateName.ToLower() && e.firstName.ToLower() == statePersonName.ToLower()).ToList())
                        {
                            Console.WriteLine("The Contact Details of " + data.state + " are:\n-------------------------" + "\nFirstName: " + data.firstName + " " + "\nLastName: " + data.lastName + " " + "\nZipcode: " + data.zipcode + " " + "\nPhoneNumber: " + data.phoneNumber);
                            Console.WriteLine("\nPress any key to continue....");
                            Console.ReadLine();//
                            return;
                        }
                    }
                    Console.WriteLine("Person With Name ==> {0} is not found in the AddressBook in State ==> {1}", statePersonName, stateName);
                    Console.WriteLine("\nPress any key to continue.....");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("select only valid options");
                    break;
            }
            Console.ReadLine();
        }
        /// <summary>
        /// UC9- Ability to View Person by City or State.
        /// </summary>
        public static void ViewPersonByCityOrState()
        {
            Console.Clear();
            Console.WriteLine("First select options:--");
            Console.WriteLine("1.View Person In City\n2.View Person In State\n");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter that City name where want to view the person name ");
                    string cityName = Console.ReadLine();
                    foreach (var pair in dictionarybook.Keys)
                    {
                        Console.WriteLine("Address Book Name: " + pair);
                        Console.WriteLine("The Contact Details of {0} are:\n--------------------------", cityName);
                        foreach (Contacts data in Person.FindAll(s => s.city.ToLower() == cityName.ToLower()).ToList())
                        {
                            Console.WriteLine("\nFirstName: " + data.firstName + " " +
                                "\nLastName: " + data.lastName + " " +
                                "\nZipcode: " + data.zipcode + " " +
                                "\nAddress: " + data.address + " " +
                                "\nStateName: " + data.state + " " +
                                "\nPhoneNumber: " + data.phoneNumber);
                            Console.Write("-------------------------------------------");
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter that State name where want to view the person name ");
                    string stateName = Console.ReadLine();
                    foreach (var pair in dictionarybook.Keys)
                    {
                        Console.WriteLine("Address Book Name: " + pair);
                        Console.WriteLine("The Contact Details of {0} are:\n--------------------------", stateName);
                        foreach (Contacts data in Person.FindAll(s => s.state.ToLower() == stateName.ToLower()).ToList())
                        {
                            Console.WriteLine("\nFirstName: " + data.firstName + " " +
                                "\nLastName: " + data.lastName + " " +
                                "\nZipcode: " + data.zipcode + " " +
                                "\nAddress: " + data.address + " " +
                                "\nStateName: " + data.state + " " +
                                "\nPhoneNumber: " + data.phoneNumber);
                            Console.Write("-------------------------------------------");
                        }
                    }
                    break;
                default:
                    Console.WriteLine("select only valid options");
                    break;
            }
            Console.ReadLine();
        }
        /// <summary>
        /// UC10- Ability to get number of contact persons i.e. count by City or State.
        /// </summary>
        public static void CountCityOrState()
        {
            Console.Clear();
            Console.WriteLine("Enter the CityOrState name that want to count ");
            string cityOrState = Console.ReadLine();
            foreach (var data in Person)
            {
                if (Person.Contains(data))
                {
                    if (data.city.ToLower() == cityOrState.ToLower())
                    {
                        var values = Person.Count(x => x.city.ToLower() == cityOrState.ToLower());
                        Console.WriteLine("In {0} total number of person: {1}", cityOrState, values);
                        Console.ReadLine();
                        return;
                    }
                    else
                    {
                        if (data.state == cityOrState)
                        {
                            var values = Person.Count(x => x.state.ToLower() == cityOrState.ToLower());
                            Console.WriteLine("In {0} total number of person: {1}", cityOrState, values);
                            Console.ReadLine();
                            return;
                        }
                    }
                    Console.WriteLine("In {0} no person is present", cityOrState);
                    //Console.ReadLine();
                    return;
                }
            }
        }
        /// <summary>
        /// UC11- sort the entries in the address book alphabetically by Person’s name'
        /// </summary>
        public static void SortPersonsName()
        {
            Console.Clear();
            var values = Person.OrderBy(x => x.firstName.ToLower()).ToList();
            Console.WriteLine("Sort person name in alphabetically");
            Console.WriteLine("-------------------------------------");
            foreach (var result in values)
            {
                Console.WriteLine("FirstName:" + result.firstName + "   " +
                               "LastName: " + result.lastName + "   " +
                                "Zipcode: " + result.zipcode + "   " +
                                "Address: " + result.address + "   " +
                                "StateName: " + result.state + "   " +
                                "PhoneNumber: " + result.phoneNumber);
            }
            Console.ReadLine();
        }
        /// <summary>
        /// UC12- Sort the person in the address book by City, State, or Zip.
        /// </summary>
        public static void SortPersonByCityStateOrZip()
        {
            Console.Clear();
            var citysort = Person.OrderBy(x => x.city.ToLower()).ToList();
            var statesort = Person.OrderBy(x => x.state.ToLower()).ToList();
            var zipcodesort = Person.OrderBy(x => x.zipcode).ToList();
            Console.WriteLine("Sort person name by city name");
            Console.WriteLine("--------------------------------------");
            foreach (var result in citysort)
            {
                Console.WriteLine("CityName:" + result.city + "    " + "FirstName:" + result.firstName);
            }
            Console.WriteLine("Sort person name by state name");
            Console.WriteLine("-----------------------------------");
            foreach (var result in statesort)
            {
                Console.WriteLine("StateName:" + result.state + "    " + "FirstName" + result.firstName);
            }
            Console.WriteLine("Sort person name by zipcoad");
            Console.WriteLine("----------------------------------");
            foreach (var result in zipcodesort)
            {
                Console.WriteLine("ZipCode:" + result.zipcode + "     " + "FirstName:" + result.firstName);
            }
            Console.ReadLine();
        }
        /// <summary>
        /// UC13- Read or Write the Address Book with Persons Contact into a File using File IO
        /// </summary>
        public static void ReadWritePersonContactsByUsingFileIO()
        {
            //Write into file
            string filePath = @"E:\AddressBookSystem248\AddressBookSystem248\AddressBookSystem\PersonDetails.txt";
            StreamWriter writer = new StreamWriter(filePath);
            foreach (var data in Person)
            {
                writer.WriteLine("FirstName: " + data.firstName + "    " + "\nLastName: " + data.lastName + "    " + "\nAddress: " + data.address + "    " + "\nCityName: " + data.city + "    " + "\nStateName: " + data.state + "    " + "\nZipCode: " + data.zipcode + "    " + "\nPhoneNumber: " + data.phoneNumber + "    " + "\nEmailId: " + data.email + "\n------------------------------------");
            }
            writer.Close();
            //Read from file
            StreamReader reader = new StreamReader(filePath);
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();
        }
        /// <summary>
        /// UC14- Read or Write the Address Book with Persons Contact as CSV File.
        /// </summary>
        public static void ReadWritePersonContactsAsCSVFile()
        {
            //Write into file
            string csvFilePath = @"E:\AddressBookSystem248\AddressBookSystem248\AddressBookSystem\PersonDetailsInCSVFile.csv";
            StreamWriter writer = new StreamWriter(csvFilePath);
            CsvWriter csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csvWriter.WriteRecords(Person);
            writer.Close();
            //Read from file
            StreamReader streamReader = new StreamReader(csvFilePath);
            CultureInfo culture = CultureInfo.InvariantCulture;
            CsvReader reader = new CsvReader(streamReader, culture);
            var record = reader.GetRecords<Contacts>().ToList();
            foreach (Contacts data in record)
            {
                Console.WriteLine("FirstName: " + data.firstName + "    " + "\nLastName: " + data.lastName + "    " + "\nAddress: " + data.address + "    " + "\nCityName: " + data.city + "    " + "\nStateName: " + data.state + "    " + "\nZipCode: " + data.zipcode + "    " + "\nPhoneNumber: " + data.phoneNumber + "    " + "\nEmailId: " + data.email + "\n------------------------------------");
            }
        }
        /// <summary>
        /// UC15- Read or Write the Address Book with Persons Contact as JSON File.
        /// </summary>
        public static void ReadWritePersonContactsAsJSONFile()
        {
            //Write into file
            string jsonFilePath = @"E:\AddressBookSystem248\AddressBookSystem248\AddressBookSystem\PersonDetailsInJSONFile.json";
            string jasonData = JsonConvert.SerializeObject(Person);
            File.WriteAllText(jsonFilePath, jasonData);
            //Read from file
            string jasonData1 = File.ReadAllText(jsonFilePath);
            List<Contacts> list = JsonConvert.DeserializeObject<List<Contacts>>(jasonData1);
            foreach (Contacts data in list)
            {
                Console.WriteLine("FirstName: " + data.firstName + "    " + "\nLastName: " + data.lastName + "    " + "\nAddress: " + data.address + "    " + "\nCityName: " + data.city + "    " + "\nStateName: " + data.state + "    " + "\nZipCode: " + data.zipcode + "    " + "\nPhoneNumber: " + data.phoneNumber + "    " + "\nEmailId: " + data.email + "\n------------------------------------");
            }
        }
    }
}
