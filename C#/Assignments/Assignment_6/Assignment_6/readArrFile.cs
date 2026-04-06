using System;
using System.IO;

namespace Assignment_6
{
    class readArrFile
    {
        public static void Main()
        {
            string path = "sample.txt";

            string[] lines = {
                "Hello",
                "Welcome to C#",
                "File Handling Example",
                "Good Learning"
            };

            File.WriteAllLines(path, lines);
            Console.WriteLine("Data written to file.");

            string[] readLines = File.ReadAllLines(path);

            Console.WriteLine("\nReading from file:");

            foreach (string line in readLines)
            {
                Console.WriteLine(line);
            }
        }
    }
}