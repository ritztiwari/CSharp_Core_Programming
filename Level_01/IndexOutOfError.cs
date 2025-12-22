//Return All Characters Without Using ToCharArray()

using System;

public class IndexOutOfError
{
    public static void ErrorHandle()
    {
        string input = Console.ReadLine() ?? "";

        int.TryParse(Console.ReadLine() ?? "", out int num);

        try
        {
            Console.WriteLine(input[num]);
        }
        catch(Exception e)
        {
            Console.WriteLine("IndexOutOfRangeException caught:");
            Console.Error.WriteLine(e.ToString());
            //Console.WriteLine(e.ToString());
        }

    }
}