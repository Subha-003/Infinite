using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_1
{

    class Employee
    {
        public int Id;
        public string Name;
        public string Department;
        public double Salary;
    }
    internal class Program
    {
        static List<Employee> employees = new List<Employee>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n===== Employee Management Menu =====");
                Console.WriteLine("1. Add New Employee");
                Console.WriteLine("2. View All Employees");
                Console.WriteLine("3. Search Employee by ID");
                Console.WriteLine("4. Update Employee Details");
                Console.WriteLine("5. Delete Employee");
                Console.WriteLine("6. Exit");
                Console.WriteLine("====================================");
                Console.Write("Enter your choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        AddEmployee();
                        break;
                    case 2:
                        ViewEmployees();
                        break;
                    case 3:
                        SearchEmployee();
                        break;
                    case 4:
                        UpdateEmployee();
                        break;
                    case 5:
                        DeleteEmployee();
                        break;
                    case 6:
                        Console.Write("Exited...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }
        static void AddEmployee()
        {
            Employee emp = new Employee();

            Console.Write("Enter ID: ");
            emp.Id = Convert.ToInt32(Console.ReadLine());

            if (employees.Exists(e => e.Id == emp.Id))
            {
                Console.WriteLine("ID already exists! Try a different ID.");
                return;
            }

            Console.Write("Enter Name: ");
            emp.Name = Console.ReadLine();

            Console.Write("Enter Department: ");
            emp.Department = Console.ReadLine();

            Console.Write("Enter Salary: ");
            emp.Salary = Convert.ToDouble(Console.ReadLine());

            employees.Add(emp);
            Console.WriteLine("Employee added successfully");
        }

        static void ViewEmployees()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("No employees found.");
                return;
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Dept: {emp.Department}, Salary: {emp.Salary}");
            }
        }

        static void SearchEmployee()
        {
            Console.Write("Enter ID to search: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var emp = employees.Find(e => e.Id == id);

            if (emp != null)
            {
                Console.WriteLine($"Found: {emp.Name}, {emp.Department}, {emp.Salary}");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }

        static void UpdateEmployee()
        {
            Console.Write("Enter ID to update: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var emp = employees.Find(e => e.Id == id);

            if (emp != null)
            {
                Console.Write("Enter new Name: ");
                emp.Name = Console.ReadLine();

                Console.Write("Enter new Department: ");
                emp.Department = Console.ReadLine();

                Console.Write("Enter new Salary: ");
                emp.Salary = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Employee updated successfully!");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }

        static void DeleteEmployee()
        {
            Console.Write("Enter ID to delete: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var emp = employees.Find(e => e.Id == id);

            if (emp != null)
            {
                employees.Remove(emp);
                Console.WriteLine("Employee deleted successfully!");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }
    }
}
