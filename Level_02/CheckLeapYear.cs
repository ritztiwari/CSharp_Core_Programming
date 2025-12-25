using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Methods.Level_02
{
    internal class CheckLeapYear
    {
        /*
Write a program that takes a year as input and outputs the Year is a Leap Year or not
Hint =>
a. The LeapYear program only works for year >= 1582, corresponding to a year in the
 Gregorian calendar.
b. Also Leap year is divisible by 4 and not divisible by 100 or divisible by 400
c. Write a method to check for Leap Year using the conditions a and b
         */
        public bool IsLeapYear(int year)
        {
            if(year<1582)
            {
                Console.WriteLine("Year should be greater than or equal to 1582");
                return false;
            }
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
