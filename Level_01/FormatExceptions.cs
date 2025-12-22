//Demonstrate FormatException


using System;

public class FormatExceptions
{
	public static void ErrorHandle()
	{
		try
		{
			int num = int.Parse(Console.ReadLine());
		}
		catch (Exception e)
		{
			Console.WriteLine("FormatExceptions caught:");
			Console.Error.WriteLine(e.ToString());
		}

	}
}