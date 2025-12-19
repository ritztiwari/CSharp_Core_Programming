using System;

namespace Core_Programming.Control_flow.Level_01
{
    internal class Divisible
    {
        public void DivisibleByFive()
        {
            int num = Convert.ToInt32(Console.ReadLine());  

            Console.WriteLine($"Is the number {num} divisible by 5? {num%5==0}");

        }
    }
}
