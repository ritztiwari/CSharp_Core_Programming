//12.Write a program to calculate various trigonometric functions using Math class given an
//angle in degrees

using System;

internal class TrigonometricFunctions
{
    // Method to calculate sine, cosine and tangent
    public static double[] calculateTrigonometricFunctions(double angle)
    {
        // converting degrees to radians
        double radians = angle * Math.PI / 180;

        double sin = Math.Sin(radians);
        double cos = Math.Cos(radians);
        double tan = Math.Tan(radians);

        return new double[] { sin, cos, tan };
    }

    internal static void FindRadian()
    {
        Console.WriteLine("Enter angle in degrees:");
        double angle = double.Parse(Console.ReadLine());

        double[] result = calculateTrigonometricFunctions(angle);

        Console.WriteLine($"Sine value: {result[0]:F2}");
        Console.WriteLine($"Cosine value: {result[1]:F2}");
        Console.WriteLine($"Tangent value: {result[2]:F2}");
    }
}
