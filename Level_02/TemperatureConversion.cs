using System;
using System.Collections.Generic;
using System.Text;

namespace Core_Programming.Programming_Elements.Level_02
{ 
    internal class TemperatureConversion
    {
        public void Temp()
        {
            double temp = Convert.ToDouble(Console.ReadLine());
            double result = ((temp * 9)/5) + 32;

            Console.WriteLine($"The {temp} Celsius is {result} Fahrenheit");
        }
    }
}