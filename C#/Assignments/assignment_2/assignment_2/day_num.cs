using System;

class days
    {
        enum Days
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main()
        {
            Console.Write("Enter day number (1-7): ");
            int day = Convert.ToInt32(Console.ReadLine());

            if (day >= 1 && day <= 7)
            {
                Days d = (Days)day;
                Console.WriteLine("Day is: {0}", d);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }


