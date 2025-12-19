using System;


namespace Core_Programming.Control_flow.Level_01
{
    internal class RocketCounter1
    {
        public void Counter()
        {
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = num; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}