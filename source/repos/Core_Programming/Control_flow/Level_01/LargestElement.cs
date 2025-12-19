using System;

namespace Core_Programming.Control_flow.Level_01
{
    internal class LargestElement 
    {
        public void Largest()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine($"Is the first number the largest? {a}");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine($"Is the second number the largest? {b}");
                
            } else
            {
                Console.WriteLine($"Is the third number the largest? {c}");
            }


        }
    }
}
