using System;

internal class Multiplication_6_TO_9
{
    public void Table()
    {

        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int[] multiplicationResult = new int[4];

        int index = 0;
        for (int i = 6; i <= 9; i++)
        {
            multiplicationResult[index] = number * i;
            index++;
        }

        index = 0;
        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine($"{number} * {i} = {multiplicationResult[index]}");
            index++;
        }
    }
}
