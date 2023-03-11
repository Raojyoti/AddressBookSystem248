using System;
using System.Globalization;
using System.Reflection.Emit;

namespace AddressBookSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<PersonContactsThread> threads = new List<PersonContactsThread>();
            threads.Add(new PersonContactsThread(firstName: "Jyoti", lastName: "Rao", address: "Vijay Nagar", city: "Noida", zipcode: 784512, phoneNumber: 7815879856, email: "jrao258@gmail.com", startDate: "2018-10-12"));
            threads.Add(new PersonContactsThread(firstName: "Anmol", lastName: "Roy", address: "Murari Nagar", city: "Delhi", zipcode: 454512, phoneNumber: 8815879856, email: "anmo258@gmail", startDate: "2019-06-22"));
            threads.Add(new PersonContactsThread(firstName: "Rashi", lastName: "Raghav", address: "Shastri Nagar", city: "Agra", zipcode: 334512, phoneNumber: 9815879856, email: "rashi258@gmail.com", startDate: "2020-10-14"));
            threads.Add(new PersonContactsThread(firstName: "Amit", lastName: "Singh", address: "New Tehisl", city: "Khurja", zipcode: 224512, phoneNumber: 8815879856, email: "amit258@gmail.com", startDate: "2013-07-16"));
            threads.Add(new PersonContactsThread(firstName: "Riya", lastName: "Sharma", address: "Kalind Kunj", city: "Noida", zipcode: 284512, phoneNumber: 7815879856, email: "riya2478@gmail.com", startDate: "2015-09-18"));
            threads.Add(new PersonContactsThread(firstName: "Seema", lastName: "Yadav", address: "New Tehisl", city: "Greater Noida", zipcode: 184512, phoneNumber: 7365879856, email: "seema257@gmail.com", startDate: "2016-08-20"));
            threads.Add(new PersonContactsThread(firstName: "Piyush", lastName: "Rao", address: "Near fire satation", city: "Delhi", zipcode: 384512, phoneNumber: 9915879856, email: "piyush248@gmail.com", startDate: "2017-10-29"));
            threads.Add(new PersonContactsThread(firstName: "Atul", lastName: "Kumar", address: "G.T.Road", city: "Noida", zipcode: 924512, phoneNumber: 9615879856, email: "atul147@gmail.com", startDate: "2022-10-17"));
            threads.Add(new PersonContactsThread(firstName: "Manisha", lastName: "Singh", address: "Subash Chok", city: "Mumbai", zipcode: 184512, phoneNumber: 7235879856, email: "manisha147@gmail.com", startDate: "2011-11-12"));
            threads.Add(new PersonContactsThread(firstName: "Tarun", lastName: "Thakur", address: "Purani Teshil", city: "Agra", zipcode: 782812, phoneNumber: 7818879856, email: "tarun269@gmail.com", startDate: "2014-12-12"));

            Console.Clear();
            List<Contacts> Person = new List<Contacts>();
            Contacts contacts = new Contacts();
            Console.WriteLine("*****----Welcome to Address Book Program----*****\n");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Please select given options:---\n--------------------");
                Console.WriteLine("1.AddContacts\n" +
                    "2.DisplayDetails\n" +
                    "3.EditPersonDetails\n" +
                    "4.DeletePersonByUsingPersonName\n" +
                    "5.AddMultiplePerson\n" +
                    "6.CreateDictionaryContacts\n" +
                    "7.DisplayDictionaryList\n" +
                    "8.CheckDuplicateEntryOfSamePersonByPersonNameInList\n" +
                    "9.SearchPersonByCityOrStateInDictionaryAB\n" +
                    "10.ViewPersonByCityOrStateInDictionaryAB\n" +
                    "11.GetNumberOfContactPersonsThatIsCounrByCityOrStateInList\n" +
                    "12.SortEntriesInAddressBookByPersonsNameInList\n" +
                    "13.SortPersonByCityStateOrZipInList\n" +
                    "14.ReadOrWritePersonsContactIntoFileUsingFileIO\n" +
                    "15.ReadOrWritePersonsContactAsCSVFile\n" +
                    "16.ReadOrWritePersonsContactAsJsonFile\n" +
                    "17.Retrieve all entites from database\n" +
                    "18.Update city by using firstname\n" +
                    "19.Retrieve contacts add at particular date in address book\n" +
                    "20.Retrieve Number of Contacts by city or state\n" +
                    "21.Add new contacts in address book\n" +
                    "22.Add multiplecontacts in address book by using threads\n" +
                    "30.Exit\n");
                int option=Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        AddressBookMain.AddContacts();
                        Console.Clear();
                        break;
                    case 2:
                        AddressBookMain.DisplayDetails();
                        Console.Clear();
                        break;
                    case 3:
                        AddressBookMain.EditPersonDetails();
                        Console.Clear();
                        break;
                    case 4:
                        AddressBookMain.DeletePersonByUsingPersonName();
                        Console.Clear();
                        break;
                    case 5:
                        AddressBookMain.AddMultiplePerson();
                        Console.Clear();
                        break;
                    case 6:
                        AddressBookMain.CreateDictionaryContacts();
                        Console.Clear();
                        break;
                    case 7:
                        AddressBookMain.DisplayDictionaryList();
                        Console.Clear();
                        break;
                    case 8:
                        AddressBookMain.CheckDuplicateEntryOfSamePersonByName();
                        Console.Clear();
                        break;
                    case 9:
                        AddressBookMain.SearchPersonByCityOrState();
                        Console.Clear();
                        break;
                    case 10:
                        AddressBookMain.ViewPersonByCityOrState();
                        Console.Clear();
                        break;
                    case 11:
                        AddressBookMain.CountCityOrState();
                        Console.Clear();
                        break;
                    case 12:
                        AddressBookMain.SortPersonsName();
                        Console.Clear();
                        break;
                    case 13:
                        AddressBookMain.SortPersonByCityStateOrZip();
                        Console.Clear();
                        break;
                    case 14:
                        Console.Clear();
                        Console.WriteLine("Data is write in file successfully......");
                        Console.WriteLine("\nNow Reading Details of Persons In Address Book by using FileIO:\n-----------------------------------------------");
                        AddressBookMain.ReadWritePersonContactsByUsingFileIO();
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 15:
                        Console.Clear();
                        Console.WriteLine("Data is write in Csv file successfully......");
                        Console.WriteLine("\nNow Reading Details of Persons In Address Book from csv file:\n-----------------------------------------------------------");
                        AddressBookMain.ReadWritePersonContactsAsCSVFile();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 16:
                        Console.Clear();
                        Console.WriteLine("Data is write in Json file successfully......");
                        Console.WriteLine("\nNow Reading Details of Persons In Address Book from Json file:\n-----------------------------------------------------------");
                        AddressBookMain.ReadWritePersonContactsAsJSONFile();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 17:
                        Console.Clear();
                        Console.WriteLine("Retrieve all entites from database\n---------------------------------- ");
                        AddressRepository.GetAllEntriesFromDB();
                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadLine();
                        break;
                    case 18:
                        Console.Clear();
                        contacts.firstName = "Anmol";
                        contacts.city = "Punjab";
                        AddressRepository.UpdateContacts(contacts);
                        Console.WriteLine("Details of address book After Update city are\n------------------------------------------------");
                        AddressRepository.GetAllEntriesFromDB();
                        Console.ReadLine();
                        Console.Write("\nPress any key to continue...... ");
                        Console.Clear();
                        break;
                    case 19:
                        Console.Clear();
                        Console.WriteLine("Retrieve by Particular date or state\n-------------------------------------------");
                        AddressRepository.RetrieveParticularDate(contacts);
                        Console.ReadLine();
                        Console.Write("\nPress any key to continue...... ");
                        Console.Clear();
                        break;
                    case 20:
                        Console.Clear();
                        Console.WriteLine("Retrieve by city or state\n-------------------------------------------");
                        AddressRepository.RetrieveByCityOrState(contacts);
                        break;
                    case 21:
                        Console.Clear();
                        contacts.firstName = "Aakansha";
                        contacts.lastName = "Singh";
                        contacts.address = "Preet vihar colony";
                        contacts.city = "Uttarakhand";
                        contacts.state = "Dehra Dun";
                        contacts.zipcode = 232513;
                        contacts.phoneNumber = 7505982525;
                        contacts.email = "aakan123@gmail.com";
                        AddressRepository.AddNewContacts(contacts);
                        Console.WriteLine("Retrieve all entites from database after add new contacts\n---------------------------------------------------------- ");
                        AddressRepository.GetAllEntriesFromDB();
                        Console.WriteLine("\nPress any key to continue...... ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 22:
                        Console.Clear();
                        Console.WriteLine("Details of all contacts present in Address book:\n----------------------------------------");
                        AddressRepository employeePayRoll = new AddressRepository();
                        DateTime startdateTime = DateTime.Now;
                        employeePayRoll.AddMultipleContactsInAddressBookWithThread(threads);
                        DateTime stopdateTime = DateTime.Now;
                        Console.WriteLine("\nDuation with thread:  {0}", (stopdateTime - startdateTime));
                        int result = employeePayRoll.ContactsCount();
                        Console.WriteLine("Number of contacts present in address book: {0}", result);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 30:
                        Console.Clear();
                        Console.ReadLine();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Select only give options");
                        break;
                }
            }
        }
    }
}