using ProductReviewManagementWithLinq;
using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookProblemLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book problem statement");

            List<AddressBook> address = new List<AddressBook>()
            {
                 new AddressBook{Name="Vaibhav",Contact=9359864239,City="Pune",State="Maharashtra",Pin=431115},
                 new AddressBook{Name="Pratibha",Contact=9359868837,City="Pune",State="Maharashtra",Pin=431116},
                 new AddressBook{Name="Nita",Contact=9959864239,City="Abad",State="Maharashtra",Pin=432355},
                 new AddressBook{Name="Sandip",Contact=9759868837,City="Abad",State="Maharashtra",Pin=432216},
            };
            Book bk = new Book();
            bk.TopRecords(address);
        }
    }
}
