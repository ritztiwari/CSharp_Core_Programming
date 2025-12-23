using System;
using System.Text;

internal class RemoveDuplicates
{
    internal static void Remove()
    {
        Console.WriteLine("enter the String");
        string input = Console.ReadLine() ?? "";

        string s = "";

        for(int i = 0; i < input.Length; i++)
        {
            bool duplicate = false;
            for (int j = 0; j < s.Length; j++)
            {
                if (input[i] == s[j])
                {
                    duplicate = true;
                    break;
                }
            }

            if (!duplicate)
            {
                s += input[i];
            }
        }

        Console.WriteLine($"the unique string is {s}");
    } 
}