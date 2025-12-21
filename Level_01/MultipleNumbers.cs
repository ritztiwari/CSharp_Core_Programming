using System;

public class MultipleNumbers
{
    public void Number()
    {
        int n = 10;
        int[] arr = new int[n];

        for(int i = 0; i < n; i++)
        {
            if (int.TryParse(Console.ReadLine(), out int value)){
                if(value != 0)
                {
                    arr[i] = value;
                }
                else
                {
                    break;
                }
            }
            
        }

        double total = 0;

        //Console.WriteLine(string.Join(",",arr));

        foreach(int i in arr)
        {
            total += i;
        }

        Console.WriteLine(total);   
    }
}