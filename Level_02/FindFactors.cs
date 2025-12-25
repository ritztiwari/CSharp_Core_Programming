using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Methods.Level_02
{
    internal class FindFactors
    {
        /*
Create a program to find the factors of a number taken as user input, store the factors in
an array and display the factors. Also find the sum, sum of square of factors and product of
the factors and display the results
Hint =>
1. Take the input for a number
2. Write a static Method to find the factors of the number and save them in an array
and return the array.
3. To find factors and save to array will have two loops. The first loop to find the count
and initialize the array with the count. And the second loop save the factors into the
array
4. Write a method to find the sum of the factors using factors array
5. Write a method to find the product of the factors using factors array
6. Write a method to find the sum of square of the factors using Math.Pow() method
        */
        public static int[] FindAllFactors(int number)
        {
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            int[] factors = new int[count];
            int index = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    factors[index] = i;
                    index++;
                }
            }
            return factors;
        }

        public int SumOfFactors(int[] factors)
        {
            int sum = 0;
            foreach (int factor in factors)
            {
                sum += factor;
            }
            return sum;
        }
        public int ProductOfFactors(int[] factors)
        {
            int product = 1;
            foreach (int factor in factors)
            {
                product *= factor;
            }
            return product;
        }
        public double SumOfSquareOfFactors(int[] factors)
        {
            double sumOfSquares = 0;
            foreach (int factor in factors)
            {
                sumOfSquares += Math.Pow(factor, 2);
            }
            return sumOfSquares;
        }


    }
}
