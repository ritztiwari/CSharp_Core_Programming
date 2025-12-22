//Demonstrate NullReferenceExceptions

using System;

public class NullReferenceExceptions
{
    public static void ErrorHandle()
    {
        string input = null;

        try
        {
            Console.WriteLine(input.Length);
        }
        catch (Exception e)
        {
            Console.WriteLine("NullReferenceExceptions caught:");
            Console.Error.WriteLine(e.ToString());
            //Console.WriteLine(e.ToString());
        }

    }
}