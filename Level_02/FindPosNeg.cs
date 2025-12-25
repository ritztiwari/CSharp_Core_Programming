using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Methods.Level_02
{
    internal class FindPosNeg
    {
        /*
Write a program to take user input for 5 numbers and check whether a number is
positive or negative. Further for positive numbers check if the number is even or odd. Finally
compare the first and last elements of the array and display if they are equal, greater, or less
Hint =>
a. Write a Method to Check whether the number is positive or negative
b. Write a Method to check whether the number is even or odd
c. Write a Method to compare two numbers and return 1 if number1 > number2
or 0 if both are equal or -1 if number1 < number2
d. In the main program, Loop through the array using the length call the method
isPositive() and if positive call method isEven() and print accordingly
e. If the number is negative, print negative.
f. Finally compare the first and last element of the array by calling the method
compare() and display if they arre equal, greater, or less
         */
        public int PosNeg(int num)
        {
            if (num > 0) return 1;
            else return 0;

        }
        public int IsEvenOdd(int num)
        {
            if (num % 2 == 0) return 1;
            else return 0;
        }
        public int Compare(int num1, int num2)
        {
            if(num1>num2)
            {
                return 1;
            }
            else if(num1<num2)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
