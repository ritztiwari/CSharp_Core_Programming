using System;

namespace Core_Programming.Programming_Elements.Level_02
{
    internal class Marathen
    {
        public void Run()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int rounds = 5000 / (a + b + c);


            Console.WriteLine($"The total number of rounds the athlete will run is {rounds} to complete 5km");
        }
    }
}
