//Write a program to input the Principal, Rate, and Time values and calculate Simple
//Interest.
    
using System;

internal class SimpleInterest
{
    internal static void FindSI(double principle,double rate,double time)
    {
        // applying formula for calculating the SI.
        double si = (principle * rate * time)/100;

        // output.
        Console.WriteLine($"the simple interest is {si} for principla rate {principle}, rate of interest {rate} and time {time}");
    }
    internal static void Interest()
    {

        // taking input from user about principle,rate,time.
        Console.WriteLine("enter the principle amount:");
        double.TryParse(Console.ReadLine() ?? "", out double principle);

        Console.WriteLine("enter the rate:");
        double.TryParse(Console.ReadLine() ?? "", out double rate);

        Console.WriteLine("enter the time for loan:");
        double.TryParse(Console.ReadLine() ?? "", out double time);

        // method calling for calculating SI.
        FindSI(principle, rate, time);
    }
}