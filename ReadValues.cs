using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
    public static class ReadValues
    {
        public static void read()
        {
            string firstName;
            string lastName;
            string address;
            string city;
            string state;
            int zip;
            long phone_number;
            string email;
            Console.WriteLine("Enter your first name:");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter your address:");
            address = Console.ReadLine();
            Console.WriteLine("Enter your city:");
            city = Console.ReadLine();
            Console.WriteLine("Enter your state:");
            state = Console.ReadLine();
            Console.WriteLine("Enter zip code:");
            zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter phone number:");
            phone_number = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your email:");
            email = Console.ReadLine();
            Console.WriteLine();
            AddressBookMain obj = new AddressBookMain(firstName,lastName,address,city,state,zip,phone_number,email);
        }

        public static void edit()
        {
            Console.WriteLine("Enter new first name:");
            string firstName=Console.ReadLine();
            AddressBookMain obj= new AddressBookMain();
            obj.NameEdit(firstName);
        }
    }
}
