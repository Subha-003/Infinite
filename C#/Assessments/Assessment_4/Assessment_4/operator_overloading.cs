using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_4
{
    public class Distance
    {
        public int Kilometer;
        public Distance(int km)
        {
            Kilometer = km;
        }
        public static Distance operator +(Distance d1, Distance d2)
        {

            return new Distance(d1.Kilometer + d2.Kilometer);
        }
        public void Display()
        {
            Console.WriteLine("Total Distance: " + Kilometer + " km");

        }
    internal class Operator_overloading
        {
            static void Main()
            {
                Console.Write("enter distance 1 : ");
                int dist1 =int.Parse(Console.ReadLine());
                Console.Write("enter distance 2 : ");
                int dist2 = int.Parse(Console.ReadLine());

                Distance d1 = new Distance(dist1);
                Distance d2 = new Distance(dist2);
                Distance d3 = d1 + d2;

                d3.Display();
            }
        }
    }
}
