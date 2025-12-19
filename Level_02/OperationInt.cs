using System;
using System.Collections.Generic;
using System.Text;

namespace Core_Programming.Programming_Elements.Level_02
{
    internal class OperationInt
    {
        public void ThreeOperations()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The results of Int Operations are {a+b*c},{a*b+c}, and {c+a/b} ");    
        }
    }
}