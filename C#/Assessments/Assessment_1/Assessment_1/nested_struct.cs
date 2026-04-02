using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_1
{
    struct DateOfBirth
    {
        public int Day;
        public int Month;
        public int Year;
    }

    struct Employees
    {
        public string Name;
        public DateOfBirth DOB;
    }

    class nested_struct
    {
        static void Main()
        {
            
            Employees[] emp = new Employees[2];

            for (int i = 0; i < emp.Length; i++)
            {
                Console.Write("Name of the employee: ");
                emp[i].Name = Console.ReadLine();

                Console.Write("Input day of the birth: ");
                emp[i].DOB.Day = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input month of the birth: ");
                emp[i].DOB.Month = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input year for the birth: ");
                emp[i].DOB.Year = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("--------------- Employee Details ------------------");

            for (int i = 0; i < emp.Length; i++)
            {
                Console.WriteLine($"Name: {emp[i].Name}");
                Console.WriteLine($"DOB: {emp[i].DOB.Day}/{emp[i].DOB.Month}/{emp[i].DOB.Year}\n");
            }
        }
    }
}
