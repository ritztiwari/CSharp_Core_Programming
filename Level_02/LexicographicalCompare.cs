using System;

class LexicographicalCompare
{
    internal static void Sort()
    {
        Console.Write("Enter first string: ");
        string s1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string s2 = Console.ReadLine();

        int minLength = s1.Length < s2.Length ? s1.Length : s2.Length;
        bool decided = false;

        for (int i = 0; i < minLength; i++)
        {
            if (s1[i] < s2[i])
            {
                Console.WriteLine("Sorted Order:");
                Console.WriteLine(s1);
                Console.WriteLine(s2);
                decided = true;
                break;
            }
            else if (s1[i] > s2[i])
            {
                Console.WriteLine("Sorted Order:");
                Console.WriteLine(s2);
                Console.WriteLine(s1);
                decided = true;
                break;
            }
        }

        if (!decided)
        {
            if (s1.Length <= s2.Length)
            {
                Console.WriteLine("Sorted Order:");
                Console.WriteLine(s1);
                Console.WriteLine(s2);
            }
            else
            {
                Console.WriteLine("Sorted Order:");
                Console.WriteLine(s2);
                Console.WriteLine(s1);
            }
        }
    }
}
