//Rewrite the above program using multi-dimensional array to store height, weight, and BMI in
//2D array for all the persons

using System;

class BmiUsing2DArray
{
    public void FindBmi()
    {
        Console.Write("Enter number of persons: ");
        int number = int.Parse(Console.ReadLine() ?? "0");

        double[][] personData = new double[number][];
        string[] weightStatus = new string[number];

        for (int i = 0; i < number; i++)
        {
            personData[i] = new double[3];

            double weight, height;

            while (true)
            {
                Console.Write($"Enter weight (kg) of person {i + 1}: ");
                if (double.TryParse(Console.ReadLine() ?? "", out weight) && weight > 0)
                    break;
                Console.WriteLine("Enter a positive value.");
            }

            while (true)
            {
                Console.Write($"Enter height (meters) of person {i + 1}: ");
                if (double.TryParse(Console.ReadLine() ?? "", out height) && height > 0)
                    break;
                Console.WriteLine("Enter a positive value.");
            }

            personData[i][0] = weight;
            personData[i][1] = height;

            double bmi = weight / (height * height);
            personData[i][2] = bmi;

            if (bmi < 18.5)
                weightStatus[i] = "Underweight";
            else if (bmi < 25)
                weightStatus[i] = "Normal";
            else if (bmi < 30)
                weightStatus[i] = "Overweight";
            else
                weightStatus[i] = "Obese";
        }

        Console.WriteLine("\nPerson Details:");
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine($"Person {i + 1}");
            Console.WriteLine($"Weight: {personData[i][0]} kg");
            Console.WriteLine($"Height: {personData[i][1]} m");
            Console.WriteLine($"BMI: {personData[i][2]:F2}");
            Console.WriteLine($"Status: {weightStatus[i]}");
            Console.WriteLine();
        }
    }
}
