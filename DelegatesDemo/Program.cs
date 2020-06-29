using DemoClassLibrary;
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
            Employeelist();
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

            // First example
            employee.PromotedEmployee(employee.empList, (employee)=> employee.Experience>5);
            Console.WriteLine();
            
            // Second example
            employee.PromotedEmployee(employee.empList, PromotableEmployee);
            Console.WriteLine();


            Console.WriteLine("Please enter any key to exit the application...");
            Console.Read();
        }
        public static  ShoppingCartModel cart = new ShoppingCartModel();
        public static EmployeeTest employee = new EmployeeTest();
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
        private static bool PromotableEmployee(Employee emp)
        {
            if (emp.Experience > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
        private static void PopulatedCartWtithDemoData()
        {
            cart.Items.Add(new ProductModel { ItemName = "Milk", Price = 50.62M });
            cart.Items.Add(new ProductModel { ItemName = "Milk1", Price = 70.62M });
            cart.Items.Add(new ProductModel { ItemName = "Milk2", Price = 60.62M });
            cart.Items.Add(new ProductModel { ItemName = "Milk3", Price = 80.62M });
        }
        private static void Employeelist()
        {
            employee.empList.Add(new Employee { ID = 01, Name = "Somrat akbor", Salary = 950000.00M, Experience = 2 });
            employee.empList.Add(new Employee { ID = 02, Name = "Moazzam Hossain", Salary = 5000.00M, Experience = 5 });
            employee.empList.Add(new Employee { ID = 03, Name = "Md Raihan", Salary = 90000.00M, Experience = 6 });
            employee.empList.Add(new Employee { ID = 04, Name = "Atikur Rahman", Salary = 9000.00M, Experience = 1 });
            employee.empList.Add(new Employee { ID = 05, Name = "Md Shobhan", Salary = 15100.00M, Experience = 5});
            employee.empList.Add(new Employee { ID = 06, Name = "Md Asif", Salary = 52000.00M, Experience = 3 });
            employee.empList.Add(new Employee { ID = 07, Name = "Touhidul Islam Noman", Salary = 55000.00M, Experience = 4 });
        }
    }
}
