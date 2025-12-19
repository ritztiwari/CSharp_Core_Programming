using System;

namespace Core_Programming.Programming_Elements.Level_02
{
    internal class SwapNumbers
    {
        public void Swap()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;


            Console.WriteLine($"The swapped numbers are {a} and {b}");
        }
    }
}
