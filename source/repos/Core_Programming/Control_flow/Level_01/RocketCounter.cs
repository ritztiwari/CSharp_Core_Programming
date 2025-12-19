using System;


namespace Core_Programming.Control_flow.Level_01
{
    internal class RocketCounter
    {
        public void Counter()
        {
            int num = Convert.ToInt32(Console.ReadLine());

            while(num > 0)
            {
                Console.WriteLine(num);
                num--;
            }
        }
    }
}