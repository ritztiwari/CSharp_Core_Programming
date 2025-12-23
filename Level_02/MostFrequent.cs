using System;

public class MostFrequent
{
    public static void Frequent()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine() ?? "";

        int[] freq = new int[256];

        for (int i = 0; i < input.Length; i++)
        {
            freq[input[i]]++;
        }

        int maxCount = 0;
        char result = '\0';

        for (int i = 0; i < input.Length; i++)
        {
            if (freq[input[i]] > maxCount)
            {
                maxCount = freq[input[i]];
                result = input[i];
            }
        }

        Console.WriteLine($"Most Frequent Character: '{result}'");
    }
}
