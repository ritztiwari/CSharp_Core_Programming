//An athlete runs in a triangular park with sides provided as input by the user in meters. If
//the athlete wants to complete a 5 km run, then how many rounds must the athlete
//complete

using System;

internal class TriangularParkRun
{
	// Method to calculate number of rounds to complete 5 km run
	public static double CalculateRounds(double side1, double side2, double side3)
	{
		// perimeter of triangle
		double perimeter = side1 + side2 + side3;

		// total distance to cover (5 km = 5000 meters)
		double totalDistance = 5000;

		// calculating number of rounds
		double rounds = totalDistance / perimeter;

		return rounds;
	}

	internal static void FindRun()
	{
		// taking input from user
		Console.WriteLine("Enter side 1 of the triangle (in meters):");
		double side1 = double.Parse(Console.ReadLine());

		Console.WriteLine("Enter side 2 of the triangle (in meters):");
		double side2 = double.Parse(Console.ReadLine());

		Console.WriteLine("Enter side 3 of the triangle (in meters):");
		double side3 = double.Parse(Console.ReadLine());

		// method call
		double result = CalculateRounds(side1, side2, side3);

		Console.WriteLine($"Number of rounds to complete 5 km run: {result}");
	}
}
