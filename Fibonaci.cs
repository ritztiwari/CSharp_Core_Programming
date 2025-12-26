using System;

internal class Fibonaci
{
    public static void Check()
    {
        int.TryParse(Console.ReadLine() ?? "", out int num);

        int a = 0, b = 1, c;

        for (int i = 1; i <= num; i++)
        {
            Console.Write(a + " ");
            c = a + b;
            a = b;
            b = c;
        }
    }
}