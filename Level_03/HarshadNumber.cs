using System;

namespace CSharp_Control_Flows.Level_03
{
    internal class HarshadNumber
    {
        public void CheckHarshadNumber()
        {
            // a is the user input to check the given number is harshad number or not.
            int a = Convert.ToInt32(Console.ReadLine());

            // sum is variable that will store sum of digits. 
            int sum = 0;
            int num = a;
            // iterating.

            while (num > 0)
            {
                int k = num % 10;
                sum += k;
                num /= 10;
            }

            if(a % sum == 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
