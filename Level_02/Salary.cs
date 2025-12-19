using System;
using System.Text;

namespace Core_Programming.Programming_Elements.Level_02
{
    internal class Salary
    {
        public void TotalSalary()
        {
            int salary = Convert.ToInt32(Console.ReadLine());
            int bonus = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"The salary is INR {salary} and bonus is INR {bonus}. Hence Total Income is INR {salary+bonus}");
        }
    }
}
