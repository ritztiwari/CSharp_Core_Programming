using System;
using System.Collections.Generic;
using System.Text;

namespace Core_Programming.Programming_Elements.Level_02
{
    internal class TemperatureConversionToFahrenheit
    {
        public void Temp()
        {
            double tempInFahrenheit = Convert.ToDouble(Console.ReadLine());
            double result = (tempInFahrenheit - 32) * 5/9;

            Console.WriteLine($"The {tempInFahrenheit} Fahrenheit is {result} Celsius");
        }
    }
}