using System;

class repeat_num
{
    static void Main()
    {
        Console.Write("Enter a digit: ");
        int num = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("{0} {0} {0} {0}", num);
            Console.WriteLine("{0}{0}{0}{0}", num);
        }
    }
}