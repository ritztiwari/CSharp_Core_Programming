using System;

public class MultplicationTable
{
    public void Table()
    {
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"{n} * {i} = {n*i}");
        }
        
    }
}