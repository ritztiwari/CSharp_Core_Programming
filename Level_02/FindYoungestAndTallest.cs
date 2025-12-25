using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Methods.Level_02
{
    internal class FindYoungestAndTallest
    {
        /*
Create a program to find the youngest friends among 3 Amar, Akbar and Anthony
based on their ages and tallest among the friends based on their heights and display it
Hint =>
a. Take user input for age and height for the 3 friends and store it in two arrays
each to store the values for age and height of the 3 friends
b. Write a Method to find the youngest of the 3 friends
c. Write a Method to find the tallest of the 3 friends
         */
        public void FindYoungest(int[] ages)
        {
            int youngest = ages[0];
            for(int i=1; i < ages.Length; i++)
            {
                if (ages[i]<youngest)
                {
                    youngest = ages[i];
                }
            }
            Console.WriteLine("Youngest age among three friends is: " + youngest);
        }
        public void FindTallest(double[] heights)
        {
            double tallest = heights[0];
            for (int i = 1; i < heights.Length; i++)
            {
                if (heights[i] > tallest)
                {
                    tallest=heights[i];
                }
            }
            Console.WriteLine("Tallest height among three friends is: " + tallest);
        }
    }
}
