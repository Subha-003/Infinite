using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_2
{
    internal class exception
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("enter a number :");
                int num = int.Parse(Console.ReadLine());

                checknum(num);
            }
            catch (Exception ex)
            {
                Console.WriteLine("error : " + ex.Message);
            }

        }
        static void checknum(int number)
        {
            if (number < 0)
            {
                throw new Exception("Number cannot be negative");
            }

            Console.WriteLine("Valid number: " + number);
        }
    }
}

