using System;
using System.Collections.Generic;
using System.Text;

namespace Core_Programming.Programming_Elements.Level_02
{
    internal class OperationDouble
    {
        public void ThreeOperations()
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The results of Int Operations are {a + b * c:f2},{a * b + c:f2}, and {c + a / b:f2} ");
        }
    }
}