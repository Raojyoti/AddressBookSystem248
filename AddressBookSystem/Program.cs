using System;

namespace AddressBookSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            List<Contacts> Person = new List<Contacts>();
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
                    "17.Exit\n");
                int option=Convert.ToInt32(Console.ReadLine());
                switch(option)
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
                    case 17:
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