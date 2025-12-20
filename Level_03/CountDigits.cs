using System;

namespace CSharp_Control_Flows.Level_03
{
    internal class CountDigits
    {
        public void Count()
        {
            // a is the number.
            int a = Convert.ToInt32(Console.ReadLine());

            // Count is variable that will store no. of digits. 
            int count = 0;

            // iterating.
            while (a > 0)
            {
                a /= 10;
                count++;
            }

            Console.WriteLine($"Total number of digits in the given number are {count}");
        }
    }
}
