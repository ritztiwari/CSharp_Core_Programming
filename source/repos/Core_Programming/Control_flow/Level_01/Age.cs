using System;

namespace Core_Programming.Control_flow.Level_01
{
    internal class Age
    {
        public void VoteOrNot()
        {
            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 18)
            {
                Console.WriteLine($"The person's age is {age} and can vote.");
            }
            else
            {
                Console.WriteLine($"The person's age is {age} and can't vote.");
            }

        }
    }
}
