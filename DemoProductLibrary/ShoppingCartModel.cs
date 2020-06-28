using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProductLibrary
{
    public class ShoppingCartModel
    {
        public delegate void MentionDiscount(decimal subTotal);
        public delegate decimal DiscountTotal(List<ProductModel> items, decimal subTotal);
        public delegate void MessageShow(string Message);
        public List<ProductModel> Items { get; set; } = new List<ProductModel>();
        public decimal GenerateTotal(MentionDiscount mentionDiscount, DiscountTotal calculateDiscount, MessageShow tellUserWeAreDiscounting )
        {
            decimal subTotal = Items.Sum(x => x.Price);
            mentionDiscount(subTotal);
            tellUserWeAreDiscounting("We are applying discount");
            return calculateDiscount(Items, subTotal);
        }
    }

}
