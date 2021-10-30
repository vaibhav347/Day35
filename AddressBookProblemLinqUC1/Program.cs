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
            };
           foreach(var list in address)
            {
            Console.WriteLine("Name:-"+list.Name+" "+"Contact:-"+list.Contact+" "+"City:-"+list.City+" "+"State:-"+list.State+" "+"Pin Code:-"+list.Pin);
            }
        }
    }
}
