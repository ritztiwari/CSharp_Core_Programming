//9.Convert Text to UpperCase

using System;
using System.Text;

public class UpperCase
{
    public static string toUpperCase(string value)
    {
        StringBuilder str = new StringBuilder();

        foreach(char ch in value)
        {
            int up = ch - 32;
            str.Append((char)up);
        }

        return str.ToString();
    }

    public static void ChangeCaseToUpper()
    {
        string s = Console.ReadLine() ?? "";

        string s1 = toUpperCase(s);
        Console.WriteLine(s1);
        string s2 = s.ToUpper();

        Console.WriteLine(string.Equals(s1,s2));

    }
}