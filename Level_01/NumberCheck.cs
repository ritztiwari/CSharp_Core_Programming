//Write a program to check whether a number is positive, negative, or zero.

using System;

internal class NumberCheck()
{
    internal static string CheckNum(int num)
    {
        // checking number with condition flow.
        if (num == 0) return "Zero";

        if (num > 0) return "Positive";

        return "Negative";
    }

    internal static void Check()
    {
        // enter a number that needs to checked whether it is a positive,negative or zero.
        Console.WriteLine("enter the number:");
        int.TryParse(Console.ReadLine() ?? "", out int num);

        // method call and printing result.
        Console.WriteLine(CheckNum(num));

    }
}