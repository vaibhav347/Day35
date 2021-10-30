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
        public void TopRecords(List<ProductReviewMangement> listProductReview)
        {
            var recordsData = (from productreviews in listProductReview
                               orderby productreviews.Rating descending
                               select productreviews).Take(3);

            foreach (var list in recordsData)
            {
                Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID + " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Review + " " + "isLike:-" + list.isLike);
            }
        }
    }
}