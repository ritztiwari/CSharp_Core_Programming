using System;

namespace Core_Programming.Programming_Elements.Level_02
{
    internal class SimpleInterest
    {
        public void SI()
        {
            int principal = Convert.ToInt32(Console.ReadLine());
            int rate = Convert.ToInt32(Console.ReadLine());
            int time = Convert.ToInt32(Console.ReadLine());

            int result = (principal * rate * time) / 100;


            Console.WriteLine($"The Simple Interest is {result} for Principal {principal}, Rate of Interest {rate} and Time {time}years");
        }
    }
}
