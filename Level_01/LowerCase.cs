//10.Convert Text to Lowercase

using System;
using System.Text;

public class LowerCase
{
    public static string ToLowerCase(string value)
    {
        StringBuilder str = new StringBuilder();

        foreach (char ch in value)
        {
            int up = ch + 32;
            str.Append((char)up);
        }

        return str.ToString();
    }

    public static void ChangeCaseToLower()
    {
        string s = Console.ReadLine() ?? "";

        string s1 = ToLowerCase(s);
        string s2 = s.ToLower();

        Console.WriteLine(string.Equals(s1, s2));

    }
}