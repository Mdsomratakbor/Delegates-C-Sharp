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
            Console.WriteLine($"The total for the cart is {cart.GenerateTotal(SubTotalAlert):C2}");
            Console.WriteLine();
            Console.WriteLine("Please enter any key to exit the application...");
            Console.Read();
        }
        public static  ShoppingCartModel cart = new ShoppingCartModel();
        public static void SubTotalAlert(decimal subTotal)
        {
            Console.WriteLine($"The sub total is {subTotal}:C2");
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
