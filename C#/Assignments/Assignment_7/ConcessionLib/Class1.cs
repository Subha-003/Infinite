using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcessionLib
{
    public class Concession
    {
        public void CalculateConcession(int age, double totalFare)
        {
            if (age <= 5)
                Console.WriteLine("Little Champs - Free Ticket");
            else if (age > 60)
                Console.WriteLine("Senior Citizen - Fare: " + (totalFare * 0.7));
            else
                Console.WriteLine("Ticket Booked - Fare: " + totalFare);
        }
    }
}
