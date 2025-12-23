using System;

internal class SubOccurence
{
    internal static void Occurence()
    {
        Console.WriteLine("enter the string 1");
        string text = Console.ReadLine() ?? "";

        Console.WriteLine("enter the string 2 to find occurence");
        string pattern = Console.ReadLine() ?? "";

        int count = 0;

        for (int i = 0; i <= text.Length - pattern.Length; i++)
        {
            int j;
            for (j = 0; j<pattern.Length; j++)
            {
                if (text[i + j] != pattern[j])
                    break;
            }

            if (j == pattern.Length)
                count++;
        }

        Console.WriteLine($"total sub occurence are {count}");

    }
}