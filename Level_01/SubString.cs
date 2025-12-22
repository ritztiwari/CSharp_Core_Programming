//Create a Substring Using charAt()

using System;
using System.Text;

public class SubString
{
    public static string Sub(string str,int start, int end)
    {
        if(start > end)
        {
            return "";
        }

        StringBuilder s = new StringBuilder();

        for (int i = start; i <= end; i++)
        {
            s.Append(str[i]);
        }


        return s.ToString();
    }

    public static void CreateSubString()
    {
        string input = Console.ReadLine() ?? "";
        int.TryParse(Console.ReadLine() ?? "", out int start);
        int.TryParse(Console.ReadLine() ?? "", out int end);

        string result1 = Sub(input, start, end);
        string result2 = input.Substring(start,end);

        Console.WriteLine(result1);
        Console.WriteLine(result2);
        Console.WriteLine(string.Equals(result1, result2));

    }
}