using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    internal class char_remove
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine();

            Console.Write("Enter position: ");
            int pos = int.Parse(Console.ReadLine());

            if (pos >= 0 && pos < str.Length)
            {
                string result = str.Remove(pos, 1);
                Console.WriteLine("Result: " + result);
            }
            else
            {
                Console.WriteLine("Invalid position");
            }
        }
    }
}
