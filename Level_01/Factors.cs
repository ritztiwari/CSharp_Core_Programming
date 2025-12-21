using System;

public class Factors
{
    public void Fact()
    {
        int maxIndex = 10;
        int[] arr = new int[maxIndex];

        Console.WriteLine("enter the number:");
        int num = Convert.ToInt32(Console.ReadLine());

        int index = 0;

        for(int i=1;i <= num / 2; i++)
        {
            // resizing array
            if(maxIndex == index)
            {
                maxIndex *= 2;
                int[] temp = new int[maxIndex];

                for(int j=0;j< arr.Length; j++)
                {
                    temp[j] = arr[j];
                }
                arr = temp;
            }

            if(num % i == 0)
            {
                arr[index++] = i;
            }
        }

        Console.WriteLine(string.Join(",", arr));
    }
}