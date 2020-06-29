using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClassLibrary
{
    public class EmployeeTest
    {
        public delegate bool IsPromotable(Employee employees);
        public List<Employee> empList { get; set; } = new List<Employee>();
        public  void PromotedEmployee(List<Employee> employees, IsPromotable promotableEmployee)
        {
            foreach (var data in employees)
            {
                if (promotableEmployee(data))
                    Console.WriteLine(data.Name + " Promoted");
            }

        }
    }
}
