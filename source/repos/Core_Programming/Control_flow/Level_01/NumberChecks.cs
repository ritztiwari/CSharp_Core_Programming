using System;


namespace Core_Programming.Control_flow.Level_01
{
    internal class NumberChecks
    {
        public void Check()
        {
            int num = Convert.ToInt32(Console.ReadLine());  

            if(num == 0)
            {
                Console.WriteLine("Zero");
            }else if(num > 0)
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Negative");
            }
        }
    }
}