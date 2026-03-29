using System;

class reverse
{
    static void Main()
    {
        Console.Write("Enter a word: ");
        string word = Console.ReadLine();

        char[] arr = word.ToCharArray();
        Array.Reverse(arr);

        string reversed = new string(arr);

        Console.WriteLine("Reversed: {0}", reversed);
    }
}