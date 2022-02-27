using System;

namespace AddressBookProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            Console.WriteLine("To add an address enter 1:");
            int number=Convert.ToInt32(Console.ReadLine());
            CheckEntryValue.Check(number);
            
        }
    }

}