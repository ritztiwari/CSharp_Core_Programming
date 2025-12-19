using System;

namespace Core_Programming.Programming_Elements.Level_02
{
    internal class PoundsToKg
    {
        public void Weight()
        {
            double weight = Convert.ToDouble(Console.ReadLine());

            double result = weight * 2.2;


            Console.WriteLine($"The weight of the person in pounds is {weight} and in kg is {result}");
        }
    }
}
