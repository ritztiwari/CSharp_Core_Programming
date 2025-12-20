using System;


namespace Core_Programming.Control_flow.Level_01
{
    internal class UserSum
    {
        public void Sum()
        {
            double total = 0.0;
            double value;

            value = Convert.ToDouble(Console.ReadLine());

            while (value != 0)
            {
                total = total + value;
                value = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine($"The total sum is {total}");
        }
    }
}