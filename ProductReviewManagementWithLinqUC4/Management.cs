using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProductReviewManagementWithLinq
{
    class Management
    {
        public DataTable dataTable = new DataTable();
        public void RetrieveCountOfRecords(List<ProductReviewMangement> listProductReview)
        {
            var RecordData = listProductReview.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });
            foreach (var list in RecordData)
            {
                Console.WriteLine(list.ProductID + "------- " + list.Count);
            }
        }
    }
}