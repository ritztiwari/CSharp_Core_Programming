//Demonstrate ArgumentOutOfRangeException

using System;

public class ArgumentOutOfRangeExceptions
{
	public static void ErrorHandle()
	{
		string s = "rishabh";
		int start = 12;

		try
		{
			s = s.Substring(start);
			Console.WriteLine(s);
		}
		catch (Exception e)
		{
			Console.WriteLine("ArgumentOutOfRangeExceptions caught:");
			Console.Error.WriteLine(e.ToString());
		}

	}
}