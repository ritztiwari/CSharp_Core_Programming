using System;

namespace CSharp_Control_Flows.Level_03
{
    internal class AbundantNumber
    {
        public void CheckAbundantNumber()
        {
            // a is the user input to check the given number is harshad number or not.
            int a = Convert.ToInt32(Console.ReadLine());

            // sum is variable that will store sum of digits. 
            int sum = 0;
            
            // iterating.
            for(int i = 1; i < a; i++)
            {
                if(a % i == 0)
                {
                    sum += i;
                }
            }

            if (sum > a)
            {
                Console.WriteLine("Abundant Number.");
            }
            else
            {
                Console.WriteLine("Not Abundant Number.");
            }
        }
    }
}
