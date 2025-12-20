using System;


namespace Core_Programming.Control_flow.Level_01
{
    internal class UserSumFor
    {
        public void Sum()
        {
            double total = 0.0;
            double value;

            value = Convert.ToDouble(Console.ReadLine());

            while(true)
            {
                while( value > 0)
                {
                    total+= value;
                    value = Convert.ToDouble(Console.ReadLine());
                    continue;
                }
                break;
            }

            Console.WriteLine($"The total sum is {total}");
        }
    }
}