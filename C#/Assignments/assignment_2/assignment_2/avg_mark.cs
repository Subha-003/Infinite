using System;

class Program
    {
        static void Main()
        {
            int[] marks = new int[10];
            int sum = 0;

            
            Console.WriteLine("Enter 10 marks:");
            for (int i = 0; i < 10; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
                sum += marks[i];
            }

            int min = marks[0];
            int max = marks[0];

   
            for (int i = 0; i < 10; i++)
            {
                if (marks[i] < min)
                    min = marks[i];

                if (marks[i] > max)
                    max = marks[i];
            }

            double avg = (double)sum / 10;

            Console.WriteLine("Total : {0}", sum);
            Console.WriteLine("Average : {0}", avg);
            Console.WriteLine("Minimum : {0}", min);
            Console.WriteLine("Maximum : {0}", max);

       
            for (int i = 0; i < 10 - 1; i++)
            {
                for (int j = 0; j < 10 - i - 1; j++)
                {
                    if (marks[j] > marks[j + 1])
                    {
                        int temp = marks[j];
                        marks[j] = marks[j + 1];
                        marks[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Ascending order:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(marks[i] + " ");
            }

        
            Console.WriteLine("\nDescending order:");
            for (int i = 9; i >= 0; i--)
            {
                Console.Write(marks[i] + " ");
            }
        }
    }

