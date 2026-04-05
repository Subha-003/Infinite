using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    internal class sort_stack
    {
        public static void Main()
        { 
        
            Stack<int> stack = new Stack<int>();

            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter elements:");

            for (int i = 0; i < n; i++)
            {
                int value = int.Parse(Console.ReadLine());
                stack.Push(value);
            }

            // Convert stack to list for sorting
            List<int> list = new List<int>(stack);

            // Sort in descending order
            list.Sort();
            list.Reverse();

            // Push back to stack
            Stack<int> sortedStack = new Stack<int>();
            foreach (int item in list)
            {
                sortedStack.Push(item);
            }

            Console.WriteLine("Stack in descending order:");
            foreach (int item in sortedStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}