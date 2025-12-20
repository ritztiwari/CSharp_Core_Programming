using System;

namespace Core_Programming.Control_flow.Level_01
{
    internal class OddEven
    {
        public void CheckOddEven()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i <= num)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"number is even {i}");
                }
                else
                {
                    Console.WriteLine($"number is odd {i}");
                }

                i++;
            }

        }
    }
}
