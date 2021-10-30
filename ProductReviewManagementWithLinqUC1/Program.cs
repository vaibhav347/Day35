using System;
using System.Collections.Generic;

namespace ProductReviewManagementWithLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product review management problem statement");

            List<ProductReviewMangement> ProductReviewlist = new List<ProductReviewMangement>()
            {
                 new ProductReviewMangement(){ProductID=1,UserID=1,Rating=5,Review="Good",isLike=true},
                 new ProductReviewMangement(){ProductID=2,UserID=1,Rating=4,Review="Good",isLike=true},
                 new ProductReviewMangement(){ProductID=3,UserID=2,Rating=2,Review="Good",isLike=true},
                 new ProductReviewMangement(){ProductID=4,UserID=2,Rating=4,Review="Good",isLike=true},
                 new ProductReviewMangement(){ProductID=5,UserID=3,Rating=2,Review="nice",isLike=false},
                 new ProductReviewMangement(){ProductID=9,UserID=4,Rating=5,Review="Bad",isLike=false},
                 new ProductReviewMangement(){ProductID=1,UserID=3,Rating=1,Review="Good",isLike=false},
                 new ProductReviewMangement(){ProductID=11,UserID=10,Rating=3,Review="Good",isLike=true},
                 new ProductReviewMangement(){ProductID=10,UserID=10,Rating=3,Review="Good",isLike=true},
                 new ProductReviewMangement(){ProductID=12,UserID=10,Rating=3,Review="Good",isLike=true},
                 new ProductReviewMangement(){ProductID=13,UserID=10,Rating=3,Review="Good",isLike=true},
                 new ProductReviewMangement(){ProductID=14,UserID=10,Rating=3,Review="Good",isLike=true},
                 new ProductReviewMangement(){ProductID=15,UserID=10,Rating=3,Review="Good",isLike=true},
                 new ProductReviewMangement(){ProductID=13,UserID=1,Rating=2,Review="Good",isLike=true},
                 new ProductReviewMangement(){ProductID=16,UserID=10,Rating=3,Review="Good",isLike=true}
            };
            foreach(var list in ProductReviewlist)
            {
                Console.WriteLine("ProductID:-"+list.ProductID+" "+"UserID:-"+list.UserID+" "+"Rating:-"+list.Rating+" "+"Review:-"+list.Review+" "+"isLike:-"+list.isLike);
            }

            
        }
    }
}
