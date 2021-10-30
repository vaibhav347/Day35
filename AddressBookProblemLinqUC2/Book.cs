using AddressBookProblemLinq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProductReviewManagementWithLinq
{
    class Book
    {
        public DataTable dataTable = new DataTable();
        public void TopRecords(List<AddressBook> address2)
        {
            var recordsData = (from productreviews in address2
                               orderby productreviews.Name descending
                               select productreviews).Take(3);

            foreach (var list in recordsData)
            {
                Console.WriteLine("Name:-" + list.Name + " " + "Contact:-" + list.Contact + " " + "City:-" + list.City + " " + "State:-" + list.State + " " + "Pin Code:-" + list.Pin);
            }
        }
    }
}