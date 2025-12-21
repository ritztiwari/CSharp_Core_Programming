using System;

internal class OddEven_0_To_N
{
    internal void OddEven()
    {
        Console.WriteLine("enter the number:");
        int number = int.Parse(Console.ReadLine());

        if(number > 0)
        {
            int[] odd = new int[number / 2 + 1];
            int[] even = new int[number / 2 + 1];

            int index1 = 0;
            int index2 = 0;

            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    odd[index1] = i;
                    index1++;
                }
                else
                {
                    even[index2] = i;
                    index2++;
                }
            }

            Console.WriteLine(string.Join(",", odd));
            Console.WriteLine(string.Join(",", even));
        }
        else
        {
            Console.Write("error");
            //Console.exit(1);
        }
    }
}