//Write a C# program to count the number of vowels and consonants in a given string.

using System;
using System.Text;

public class ReverseString
{
    public static void Reverse()
    {
        Console.WriteLine("enter the sentence:");
        string s = Console.ReadLine() ?? "";

        StringBuilder str = new StringBuilder();

        for (int i = s.Length-1; i >= 0; i--)
        {
            str.Append(s[i]);
        }

        Console.WriteLine($"Reverse string is: {str.ToString()}");
    }
}