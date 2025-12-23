//Write a C# program to remove all occurrences of a specific character from a string.

using System;
using System.Text;

public class RemoveCharacter
{
    public static void Remove() 
    {
        string input = Console.ReadLine() ?? "";
        char.TryParse(Console.ReadLine() ?? "", out char input1);

        StringBuilder str = new StringBuilder();

        for(int i = 0; i < input.Length; i++)
        {
            if (input[i] != input1)
            {
                str.Append(input[i]);
            }
        }

        Console.WriteLine(str.ToString());
    }
}