namespace AddressBookSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("*****----Welcome to Address Book Program----*****\n");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Please select given options:---\n--------------------");
                Console.WriteLine("1.AddContacts\n2.DisplayDetails\n3.EditPersonDetails\n4.DeletePersonByUsingPersonName\n5.AddMultiplePerson\n17.Exit\n");
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