using System;

namespace Core_Programming.Control_flow.Level_01
{
    internal class SmallestFirst
    {
        public void First()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if(a < b && a < c)
            {
                Console.WriteLine($"Is the first number the smallest? {true}");
            }
            else
            {
                Console.WriteLine($"Is the first number the smallest? {false}");
            }
            

        }
    }
}
