using System;

namespace CSharp_Control_Flows.Level_03
{
    public static class ArmstrongNumber
    {
        public static bool CheckArmstrongNumber()
        {
            int a = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            int num = a;

            while (num > 0)
            {
                num /= 10;
                count++;
            }

            double sum = 0;
            int copyNum = a;

            while(copyNum > 0)
            {
                double k = copyNum % 10;
                sum += Math.Pow(k, count);
                copyNum /= 10;
            }

            if(sum == a)
            {
                Console.WriteLine($"the given number {a} is an Armstrong Number");
            }
            else
            {
                Console.WriteLine($"the given number {a} is not an Armstrong Number");
            }
        }
    }
}
