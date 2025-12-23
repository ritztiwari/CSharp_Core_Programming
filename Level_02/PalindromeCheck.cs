//Write a C# program to check if a given string is a palindrome (a string that reads the
//same forward and backward).

using System;
using System.Text;

public class PalindromeCheck
{
    public static bool checkString(string s,int start, int end)
    {
        while(start < end)
        {
            if (s[start] != s[end])
            {
                return false;
            }
            start++;
            end--;
        }

        return true;
    }

    public static void Check()
    {
        Console.WriteLine("enter the sentence:");
        string s = Console.ReadLine() ?? "";

        if(checkString(s, 0, s.Length))
        {
            Console.WriteLine($"the given string is a Palindrome.");
        }
        else
        {
            Console.WriteLine("the given string is not a Palindrome.");
        }
    }
}