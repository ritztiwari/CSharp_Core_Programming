using System;

internal class Anagram
{
    internal static void CheckAnagram()
    {
        Console.WriteLine("enter the string:");
        string input1 = Console.ReadLine() ?? "";
        string input2 = Console.ReadLine() ?? "";
        int j = 0;

        for(int i = 0; i < input1.Length; i++)
        {
            if(j == input2.Length)
            {
                Console.Write("both strings are anagram of each other");
                Environment.Exit(0);
            }
            if (input1[i] == input2[j])
            {
                j++;
            }
        }

        if (j == input2.Length)
        {
            Console.Write("both strings are anagram of each other");
            Environment.Exit(0);
        }
        Console.Write("both strings are not anagram of each other");
    }
}