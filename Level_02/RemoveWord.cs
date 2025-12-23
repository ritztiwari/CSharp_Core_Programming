using System;
using System.Text;

internal class RemoveWord
{
    internal static void Remove()
    {
        Console.WriteLine("enter the String");
        string input = Console.ReadLine() ?? "";

        Console.WriteLine("enter the word to remove from the string:");
        string word = Console.ReadLine() ?? "";

        Console.WriteLine("enter the word to add in the at Removed Place:");
        string word1 = Console.ReadLine() ?? "";

        string[] s = input.Split(' ');

        StringBuilder str = new StringBuilder();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i].Equals(word))
            {
                str.Append(word1+" ");
            }
            else
            {
                str.Append(s[i]+" ");
            }
        }
        
        Console.WriteLine($"updated string is: {str.ToString()}");
    }
}