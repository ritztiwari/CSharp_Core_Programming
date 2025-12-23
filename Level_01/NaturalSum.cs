//Write a program to check whether a number is positive, negative, or zero.

using System;

internal class NaturalSum()
{
    internal static int Sum(int num)
    {
        if(num < 0)
        {
            Console.WriteLine("Invalid Number");
            Environment.Exit(0);
        }
        // sum varible to store natural sum.
        int sum = 0;
        
        // looping from 0 to number to find num
        for(int i=1;i<=num;i++)
        {
            sum+= (int)i;
        }

        return sum;
    }

    internal static void Check()
    {
        // enter a number that to find natural num
        Console.WriteLine("enter the number:");
        int.TryParse(Console.ReadLine() ?? "", out int num);

        // method call and printing result.
        Console.WriteLine($"Natural sum of numbers: {Sum(num)}");

    }
}