using DemoProductLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
  
    class Program
    {
        static void Main(string[] args)
        {
            PopulatedCartWtithDemoData();
            Console.WriteLine($"The total for the cart is {cart.GenerateTotal(SubTotalAlert, CalculateDiscount, AlertUser):C2}");
            Console.WriteLine();
            decimal total = cart.GenerateTotal((subtotal) => Console.WriteLine($"The subtotal cart 2 is {subtotal:C2}"), (products, subtotal)=> {
                if (products.Count > 3)
                {
                    return subtotal * .93M;
                }
                else
                {
                    return subtotal;
                }
            }, (message)=>Console.WriteLine($"Cart 2 Alert {message}"));
            Console.WriteLine($"Cart 2 totla is {total}:C2") ;
            Console.WriteLine();

            Console.WriteLine("Please enter any key to exit the application...");
            Console.Read();
        }
        public static  ShoppingCartModel cart = new ShoppingCartModel();
        private static void SubTotalAlert(decimal subTotal)
        {
            Console.WriteLine($"The sub total is {subTotal}:C2");
        }
        private static decimal CalculateDiscount(List<ProductModel> items, decimal subTotal)
        {
            if (subTotal>100)
            {
                return subTotal * 0.90M;
            }
            return subTotal;

        }
        private static void AlertUser(string message)
        {
            Console.WriteLine(message);
        }
        private static void PopulatedCartWtithDemoData()
        {
            cart.Items.Add(new ProductModel { ItemName = "Milk", Price = 50.62M });
            cart.Items.Add(new ProductModel { ItemName = "Milk1", Price = 70.62M });
            cart.Items.Add(new ProductModel { ItemName = "Milk2", Price = 60.62M });
            cart.Items.Add(new ProductModel { ItemName = "Milk3", Price = 80.62M });
        }
    }
}
