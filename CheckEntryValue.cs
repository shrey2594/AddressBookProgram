using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
    public static class CheckEntryValue
    {
        public static void Check(int number)
        {
            if (number ==1 )
            {
                ReadValues.read();
            }
            else if (number ==2 )
            {
                ReadValues.edit();
            }
        }
    }
}
