//Return All Characters Without Using ToCharArray()

using System;

public class CreateCharArray
{   
    public static bool checkCharArray(char[] arr1, char[] arr2)
    {
        if(arr1.Length != arr2.Length)
        {
            return false;
        }

        for (int i = 0; i < arr2.Length; i++)
        {
            if( arr1[i] != arr2[i])
            {
                return false;
            }
        }

        return true;
    }

    public static void ToCreateCharArray()
    {
        string input = Console.ReadLine() ?? "";
        char[] arr = new char[input.Length];

        for(int i = 0; i < input.Length; i++)
        {
            arr[i] = input[i];
        }

        char[] arr1 = input.ToCharArray();

        Console.WriteLine($"user defined function char Array {string.Join(",",arr)}");
        Console.WriteLine($"in-built function char Array {string.Join(",",arr1)}");

        Console.WriteLine(checkCharArray(arr, arr1));
    }
}