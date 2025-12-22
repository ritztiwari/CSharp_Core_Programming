//Create a program to take a number as input find the frequency of each digit in the number
//using an array and display the frequency of each digit

using System;

public class Frequency
{
    public void Find()
    {
        string input = Console.ReadLine();
        long.TryParse(input, out long num);

        int countDigits = 0;

        long k = num;
        while (k != 0)
        {
            k /= 10;
            countDigits++;
        }

        long[] arr = new long[10];
        //int i = 0;

        while(num != 0)
        {
            int remainder = (int)num % 10;
            arr[remainder]++;
            num /= 10;
        }

        for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"no. of times {i} occured is {arr[i]}");
        }
    }
}