using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpCity { get; set; }
        public double EmpSalary { get; set; }
    }
    internal class emp_operation
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>()
        {
            new Employee { EmpId = 1, EmpName = "Arun", EmpCity = "Bangalore", EmpSalary = 50000 },
            new Employee { EmpId = 2, EmpName = "Bala", EmpCity = "Chennai", EmpSalary = 40000 },
            new Employee { EmpId = 3, EmpName = "Anu", EmpCity = "Bangalore", EmpSalary = 60000 },
            new Employee { EmpId = 4, EmpName = "Kiran", EmpCity = "Hyderabad", EmpSalary = 30000 }
        };

            Console.WriteLine("All Employees:");
            Display(employees);

            Console.WriteLine("\nSalary > 45000:");
            Display(employees.Where(e => e.EmpSalary > 45000));

            Console.WriteLine("\nBangalore Employees:");
            Display(employees.Where(e => e.EmpCity == "Bangalore"));

            Console.WriteLine("\nSorted by Name:");
            Display(employees.OrderBy(e => e.EmpName));
        }

        static void Display(IEnumerable<Employee> list)
        {
            foreach (var e in list)
            {
                Console.WriteLine($"{e.EmpId} | {e.EmpName} | {e.EmpCity} | {e.EmpSalary}");
            }
        }
    }
}
