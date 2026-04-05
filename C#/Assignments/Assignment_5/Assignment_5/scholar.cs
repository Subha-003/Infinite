using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class InvalidMarksException : ApplicationException
    {
        public InvalidMarksException(string message) : base(message) { }
    }


    class Scholarship
    {
        public double Merit(int marks, double fees)
        {
            if (marks >= 70 && marks <= 80)
                return fees * 0.20;

            else if (marks > 80 && marks <= 90)
                return fees * 0.30;

            else if (marks > 90)
                return fees * 0.50;

            else
                throw new InvalidMarksException("Marks not eligible for scholarship");
        }
    

       public static void Main()
        {
            Scholarship s = new Scholarship();

            try
            {
                double amount = s.Merit(85, 10000);
                Console.WriteLine("Scholarship Amount: " + amount);
            }
            catch (InvalidMarksException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
