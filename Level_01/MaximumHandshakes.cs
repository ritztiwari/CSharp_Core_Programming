//Create a program to find the maximum number of handshakes among N number of
//students.

using System;

internal class MaximumHandshakes
{
    internal static void CalculateMaximumHandshakes(int num)
    {
        // result will be stored in the result variable.
        int result = (num * (num - 1)) / 2;

        //output
        Console.WriteLine($"Maximum Handshakes are {result}");
    }

    internal static void Calculate()
    {
        // taking input from user
        Console.WriteLine("enter the number:");

        // TryParse returns true if input is valid and stores value in num
        // num > 0 ensures the number is greater than 0
        if (int.TryParse(Console.ReadLine(), out int num) && num > 0)
        {
            // method call
            CalculateMaximumHandshakes(num);
        }
        else
        {
            Console.Write("number should be greator than 0.");
        }
    }
}
