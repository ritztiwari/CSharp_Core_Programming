//Demonstrate IndexOutOfRangeException for Arrays

using System;

public class ArrayIndexOutOfBound
{
    public static void ErrorHandle()
    {
        try
        {
            int[] arr = { 1, 2, 3, 4,5 };
            Console.WriteLine(arr[10]);
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("IndexOutOfBoundException caught:");
            Console.Error.WriteLine(e.ToString());
        }

    }
}