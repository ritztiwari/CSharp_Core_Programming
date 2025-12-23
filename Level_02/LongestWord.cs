using System;
using System.Text;

internal class LongestWord
{
    internal static void FindLongestWord()
    {
        Console.WriteLine("enter the String");
        string input = Console.ReadLine() ?? "";

        string[] s = input.Split(' ');

        string max = "";

        for(int i = 0; i < s.Length; i++)
        {
            if (s[i].Length > max.Length)
            {
                max = s[i];
            }
        }

        Console.WriteLine($"Longest word is {max}");        
    }
}