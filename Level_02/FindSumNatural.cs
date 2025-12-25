using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Methods.Level_02
{
    internal class FindSumNatural
    {
        /*
Write a program to find the sum of n natural numbers using recursive method and
compare the result with the formulae n*(n+1)/2 and show the result from both
computations is correct.
Hint =>
a. Take the user input number and check whether it's a Natural number, if not exit
b. Write a Method to find the sum of n natural numbers using recursion
c. Write a Method to find the sum of n natural numbers using the formulae
 n*(n+1)/2
d. Compare the two results and print the result
        */

        public int SumUsingRecursion(int n)
        {
            if (n <= 1)
                return n;
            return n + SumUsingRecursion(n - 1);
        }
        public int SumUsingFormula(int n)
        {
            return n * (n + 1) / 2;
        }
        public void CompareResults(int n)
        {
            if(n<1)
            {
                Console.Error.WriteLine("Please enter a natural number greater than 0.");
                return;
            }
            int sumRecursion = SumUsingRecursion(n);
            int sumFormula = SumUsingFormula(n);
            Console.WriteLine($"Sum using Recursion: {sumRecursion}");
            Console.WriteLine($"Sum using Formula: {sumFormula}");
            if (sumRecursion == sumFormula)
            {
                Console.WriteLine("Both methods give the same result.");
            }
            else
            {
                Console.WriteLine("The results are different.");
            }
        }
    }
}
