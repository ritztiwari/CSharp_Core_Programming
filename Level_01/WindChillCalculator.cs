//11.Write a program calculate the wind chill temperature given the temperature and wind
//speed
    
using System;

internal class WindChillCalculator
{
    // Method to calculate wind chill temperature
    public static double CalculateWindChill(double temperature, double windSpeed)
    {
        //applyling the formula to find the windChill.
        double windChill =
            35.74
            + (0.6215 * temperature)
            + (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);

        return windChill;
    }

    internal static void FindWindChill()
    {

        // taking input of temperture and wind speed.
        Console.WriteLine("Enter temperature (in Fahrenheit):");
        double temperature = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter wind speed (in mph):");
        double windSpeed = double.Parse(Console.ReadLine());

        // method calling and storing the result in a variable called result.
        double result = CalculateWindChill(temperature, windSpeed);

        //output
        Console.WriteLine($"Wind Chill Temperature is: {result}");
    }
}
