//9.Write a program to take 2 numbers and print their quotient and reminder

using System;

internal class QuotientRemainder
{
    internal static void FindQuotientRemainder(int num1,int num2)
    {
        // edge case 
        if(num1 <= 0 && num1 <= 0)
        {
            Console.WriteLine("number should be greator than 0");
            Environment.Exit(0);
        }

        // output
        Console.WriteLine($"the remainder is {num1 % num2} and quotient is {num1 / num2}");
    }

    internal static void Find()
    {

        //taking inputs of two numbers num1 > num2
        Console.WriteLine("enter the 1st number:");
        int.TryParse(Console.ReadLine() ?? "", out int num1);

        Console.WriteLine("enter the 2nd number:");
        int.TryParse(Console.ReadLine() ?? "", out int num2);

        // method call
        FindQuotientRemainder(num1,num2);
    }
}