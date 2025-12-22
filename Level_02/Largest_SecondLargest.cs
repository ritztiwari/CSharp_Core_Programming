//Create a program to store the digits of the number in an array and find the largest and
//second largest element of the array.
    
using System;


public class Largest_SecondLargest
{
    public void Find()
    {
        // defining the given inputs
        const int maxIndex = 10;
        string input = Console.ReadLine();
        long.TryParse(input, out long num);

        long[] arr = new long[maxIndex];
        int i = 0;

        // taking inputs
        while(num != 0)
        {
            if (i == maxIndex) 
                break;

            arr[i++] = num % 10;
            num /= 10;
        }

        long largest = 0;
        long secondLargest = 0;

        foreach(int nums in arr)
        {
            if (largest < nums)
            {
                secondLargest = largest;
                largest = nums;
            }
            else if (largest > nums && nums != largest)
            { 
                secondLargest = nums;
            }
               
        }

        Console.WriteLine(string.Join(",", arr));
        Console.WriteLine(largest);
        Console.WriteLine(secondLargest);
    }
}