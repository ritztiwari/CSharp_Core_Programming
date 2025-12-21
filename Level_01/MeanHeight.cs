using System;

internal class MeanHeight
{
    internal void Height()
    {
        int n = 11;
        double[] arr = new double[n];

        Console.WriteLine("enter the players height:");
        for(int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(),out double value);
            arr[i] = value;
        }

        double meanHeight = 0; 
        foreach(double i in arr)
        {
            meanHeight += i;
        }

        Console.WriteLine($"the mean height of the players is {meanHeight/11:F2}");
    }
}