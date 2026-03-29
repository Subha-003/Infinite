using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1
{
    internal class Class2
    {
        static void Main()
        {
            Console.Write("Input first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input operation (+, -, *, /): ");
            char op = Convert.ToChar(Console.ReadLine());

            Console.Write("Input second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine($"{num1} + {num2} = {result}");
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine($"{num1} - {num2} = {result}");
                    break;
                case '*':
                    result = num1 * num2;
                    Console.WriteLine($"{num1} * {num2} = {result}");
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"{num1} / {num2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }
            Console.ReadLine();

        }
    }
}
