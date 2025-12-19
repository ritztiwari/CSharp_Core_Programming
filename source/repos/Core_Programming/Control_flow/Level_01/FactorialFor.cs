using System;

namespace Core_Programming.Control_flow.Level_01
{
    internal class FactorialFor
    {
        public void Fact()
        {
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                int fact = 1;

                for(int i = num; i > 0; i--)
                {
                    fact *= i;
                }

                Console.WriteLine(fact);
            }

        }
    }
}
