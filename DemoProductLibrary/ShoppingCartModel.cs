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
        public List<ProductModel> Items { get; set; } = new List<ProductModel>();
        public decimal GenerateTotal(MentionDiscount mentionDiscount, DiscountTotal calculateDiscount )
        {
            decimal subTotal = Items.Sum(x => x.Price);
            mentionDiscount(subTotal);
            return calculateDiscount(Items, subTotal);
        }
    }

}
