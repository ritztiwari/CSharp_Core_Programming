//8.Write a program to find the smallest and the largest of the 3 numbers.

using System;

internal class LargestSmallestNumber
{
	internal static void FindNumber(int num1, int num2,int num3)
	{
		// find largest and smallest using if statements and comparison operator.
		if (num1 > num2 && num1 > num3)
		{
			if (num2 > num3)
			{
				Console.WriteLine($"Largest number is {num1} and Smallest number is {num3}");
			}

		}

		if (num2 > num1 && num2 > num3)
		{
			if (num1 > num3)
			{
				Console.WriteLine($"Largest number is {num2} and Smallest number is {num3}");
			}
		}

		if (num3 > num2 && num1 < num3)
		{
			if (num1 < num2)
			{
				Console.WriteLine($"Largest number is {num3} and Smallest number is {num2}");
			}
		}
	}

	internal static void Find()
	{
		// taking inputs of 3 numbers(num1.num2,num3)
		Console.WriteLine("enter the 1st number:");
		int.TryParse(Console.ReadLine() ?? "", out int num1);

		Console.WriteLine("enter the 2nd number:");
		int.TryParse(Console.ReadLine() ?? "", out int num2);

		Console.WriteLine("enter the 3rd number:");
		int.TryParse(Console.ReadLine() ?? "", out int num3);

		// method call
		FindNumber(num1, num2, num3);
	}
}