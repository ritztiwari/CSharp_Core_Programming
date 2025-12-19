using System;

namespace Core_Programming.Programming_Elements.Level_02
{
    internal class Chocolate
    {
        public void Distribute()
        {
            Console.WriteLine("Number of Students:");
            int students = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number of chocolatese:");
            int chocolates = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"The number of chocolates each child gets is {chocolates / students} and the number of\r\nremaining chocolates is {chocolates % students}");
        }
    }
}