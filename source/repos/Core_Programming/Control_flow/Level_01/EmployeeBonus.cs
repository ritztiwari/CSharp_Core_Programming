using System;

namespace Core_Programming.Control_flow.Level_01
{
    internal class EmployeeBonus
    {
        public void Bonus()
        {
            double salary = Convert.ToDouble(Console.ReadLine());
            int yearsOfService = Convert.ToInt32(Console.ReadLine());

            double bonus = 0.0;

            if (yearsOfService > 5)
            {
                bonus = salary * 0.05;
            }

            Console.WriteLine($"The bonus amount is {bonus}");
        }
    }
}
