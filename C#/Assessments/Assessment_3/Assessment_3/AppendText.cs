using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Assessment_3
{
    public class FileHandler
    {
        public string filePath = "sample.txt";

        public void AppendText(string text)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found. Creating new file...");

                File.Create(filePath).Close();
            }

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(text);
            }

            Console.WriteLine("Text appended successfully.");
        }
    }
    public class AppendText
    {
        static void Main()
        {
            Console.Write("Enter text to append: ");
            string input = Console.ReadLine();

            FileHandler fileHandler = new FileHandler();
            fileHandler.AppendText(input);
        }
    }
}
