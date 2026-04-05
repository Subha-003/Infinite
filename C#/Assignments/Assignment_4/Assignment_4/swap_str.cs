using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    internal class swap_str
    {
        public static void Main()
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine();

            if (str.Length <= 1)
            {
                Console.WriteLine("Result: " + str);
            }
            else
            {
                char first = str[0];
                char last = str[str.Length - 1];

                string middle = str.Substring(1, str.Length - 2);

                string result = last + middle + first;

                Console.WriteLine("Result: " + result);
            }
        }

    }
}
