using System;

namespace Core_Programming.Control_flow.Level_01
{
    internal class NaturalSumCompare
    {
        public void Compare()
        {
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                int sum = num * (num + 1) / 2;
                int sum1 = 0;
                for (int i = 1; i <= num; i++)
                {
                    sum1 += i;
                }

                if(sum == sum1)
                {
                    Console.WriteLine($"equal {sum}");
                }
                else
                {
                    Console.WriteLine($"not equal {sum1}");
                    
                }
            }

        }
    }
}
