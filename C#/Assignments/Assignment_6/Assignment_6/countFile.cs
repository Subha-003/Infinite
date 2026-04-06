using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment_6
{
    internal class countFile
    {
        public static void Main()
        {
            string path = "sample.txt";

            if (File.Exists(path))
            {
                int count = File.ReadLines(path).Count();
                Console.WriteLine("Number of lines: " + count);
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}
