using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_3
{
    public class CricketTeam
    {
        public (int Count, int Sum, double Average) Pointscalculation(int no_of_matches)
        {
            int sum = 0;

            for (int i = 1; i <= no_of_matches; i++)
            {
                Console.Write($"Enter score for match {i}: ");
                int score = int.Parse(Console.ReadLine());
                sum += score;
            }

            double avg = (double)sum / no_of_matches;

            return (no_of_matches, sum, avg);
        }
    }
    internal class IplTeam
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of matches: ");
            int matches = int.Parse(Console.ReadLine());

            CricketTeam team = new CricketTeam();
            var result = team.Pointscalculation(matches);

            Console.WriteLine($"\nMatches: {result.Count}");
            Console.WriteLine($"Total Score: {result.Sum}");
            Console.WriteLine($"Average Score: {result.Average}");
        }
    }
}
