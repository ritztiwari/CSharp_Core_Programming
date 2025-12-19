using System;

namespace Core_Programming.Control_flow.Level_01
{
    internal class FactorialWhile
    {
        public void Fact()
        {
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                int fact = 1;
                while(num > 0)
                {
                    fact *= num;
                    num--;
                }

                Console.WriteLine(fact);    
            }

        }
    }
}
