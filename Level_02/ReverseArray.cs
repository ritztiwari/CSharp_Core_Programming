//Create a program to take a number as input and reverse the number. To do this, store the
//digits of the number in an array and display the array in reverse order

using System;

public class ReverseArray
{
    public void Reverse()
    {
        string input = Console.ReadLine();
        long.TryParse(input, out long num);

        int countDigits = 0;

        long k = num;
        while(k != 0)
        {
            k /= 10;
            countDigits++;
        }

        int[] reverseArray = new int[countDigits];
        int i = 0;

        while(num != 0)
        {
            long remainder = num % 10;
            reverseArray[i++] = (int)remainder;
            num /= 10;
        }

        Console.WriteLine($"reversed array is: {string.Join(",",reverseArray)}");
    }
}