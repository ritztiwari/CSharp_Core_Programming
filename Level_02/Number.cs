using System;
using System.Collections.Generic;
using System.Text;

namespace Core_Programming.Programming_Elements.Level_02
{
    internal class Number
    {
        public void Division()
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(
                $"The Quotient is {num1 / num2} and Remainder is {num1 % num2} of two numbers {num1} and {num2}"
            );
        }
    }
}
