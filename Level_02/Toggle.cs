using System;
using System.Text;

internal class Toggle
{
    internal static void ToggleString()
    {
        Console.WriteLine("enter the string:");
        string input = Console.ReadLine() ?? "";

        StringBuilder str = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i]>=65 && input[i] <= 90)
            {
                int ch = input[i] + 32;
                str.Append((char)ch);
            }
            else if(input[i] >= 97 && input[i] <= 122)
            {
                int ch = input[i] - 32;
                str.Append((char)ch);
            }
        }

        Console.WriteLine(str.ToString());
    }
}