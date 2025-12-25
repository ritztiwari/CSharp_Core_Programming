using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Methods.Level_02
{
    internal class RandomClass
    {
        /*
Write a program that generates five 4 digit random values and then finds their
average value, and their minimum and maximum value. Use Math.Random(), Math.Min(),
and Math.Max().
Hint =>
a. Write a method that generates array of 4 digit random numbers given the size
as a parameter as shown in the method signature
public int[] Generate4DigitRandomArray(int size)
b. Write a method to find average, min and max value of an array
public double[] FindAverageMinMax(int[] numbers)
         */

        public int[] Generate4DigitRandomArray(int size)
        {
            Random random = new Random();
            int[] randomValues = new int[size];
            for(int  i = 0; i < 5; i++)
            {
                randomValues[i] = random.Next(1000, 10000);
            }
            return randomValues;
        }
        public void FindAverageMinMax(int[] numbers)
        {
            int sum = 0;
            foreach(int i in numbers)
            {
                sum += i;
            }
            double avg = sum / numbers.Length;
            int min = int.MaxValue;
            int max = int.MinValue;
            foreach (int i in numbers)
            {
                if (i > max)
                {
                    max = i;
                }
                if(i < min)
                {
                    min = i;
                }
            }
            Console.WriteLine($"Average of numbers: {avg}");
            Console.WriteLine($"Minimum of numbers: {min}");
            Console.WriteLine($"Maximum of numbers: {max}");


        }

    }
}
