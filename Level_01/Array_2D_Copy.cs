using System;

public class Array_2D_Copy
{
    public void CopyArray()
    {
        // taking inputs of rows and columns 
        Console.WriteLine("enter the no. of rows:");
        int row = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("enter the no. of rows:");
        int column = Convert.ToInt32(Console.ReadLine());

        // declaration of 2d array.
        int[,] arr = new int[row, column];

        // taking inputs 
        for (int i=0;i<row;i++)
        {
            for(int j=0;j<column;j++)
            {
                arr[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // 1D array declaration.
        int[] arr1 = new int[row * column];
        int index = 0;

        // converting the 2D to 1D array.
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                arr1[index++] = arr[i,j];
            }
        }

        Console.WriteLine(string.Join(",", arr1));
     }
}