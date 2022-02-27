using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
    public class AddressBookMain
    {
        string firstName;
        string lastName;
        string address;
        string city;
        string state;
        int zip;
        long phone_number;
        string email;
        public AddressBookMain()
        {
            firstName = "Shrey";
            lastName = "Gupta";
            address = "113/6 Swaroop Nagar";
            city = "Kanpur";
            state = "U.P.";
            zip = 208002;
            phone_number = 8376009635;
            email = "shrey2510@gmail.com";
        }
        public AddressBookMain(string name,string lastName,string address,string city,string state,int zip,long contact,string email)
        {
            firstName=name;
            lastName=lastName;
            address=address;
            city=city;
            state=state;
            zip=zip;
            phone_number=contact;
            email=email;
        }
    }
}
