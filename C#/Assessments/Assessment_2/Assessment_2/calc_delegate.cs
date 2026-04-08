using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_2
{
    internal class calc_delegate
    {
        public delegate int Calculator(int a, int b);
        public static int Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Addition: " + result);
            return result;
        }

        public static int Subtract(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Subtraction: " + result);
            return result;
        }

        public static int Multiply(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Multiplication: " + result);
            return result;
        }
    
    
        public static void Main()
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Calculator c = Add;
            c += Subtract;
            c += Multiply;

            c(num1,num2);

        }
    }
}
