//An organization took up an exercise to find the Body Mass Index (BMI) of all the persons in
//the team. For this create a program to find the BMI and display the height, weight, BMI and
//status of each individual

using System;

public class BmiOfAPerson
{
    public void FindBmi()
    {
        string input = Console.ReadLine() ?? "";
        int.TryParse(input, out int num);

        double[] weight = new double[num];
        double[] height = new double[num];
        double[] BMI = new double[num];
        string[] weightStatus  = new string[num];


        // taking input from users.
        // array of weight.
        Console.WriteLine("enter the weight in Kg:");
        for(int i = 0; i < num; i++)
        {
            Console.WriteLine($"enter the weight of person {i}");
            string input1 = Console.ReadLine() ?? "";
            double.TryParse(input1,out double nums);
            weight[i] = nums;
        }

        Console.WriteLine("enter the height in Metre:");
        for(int i = 0; i < num; i++)
        {
            Console.WriteLine($"enter the height of person {i}");
            string input1 = Console.ReadLine() ?? "";
            double.TryParse(input1,out double nums);
            height[i] = nums;
        }

        // array of weight.
        for (int i = 0; i < num; i++)
        {
            double bmi = weight[i] / (height[i] * height[i]);
            BMI[i] = bmi;
        }

        // array of BMI and calculating bmi & storing it into weightStatus directly.
        for(int i = 0; i < num; i++)
        {
            if (BMI[i] < 18.4)
            {
                weightStatus[i] = "Underweight";
            }
            else if (BMI[i]>18.5 && BMI[i] < 24.9)
            {
                weightStatus[i] = "Normal";
            }
            else if (BMI[i]>25.0 && BMI[i] < 39.9)
            {
                weightStatus[i] = "Overweight";
            }
            else 
            {
                weightStatus[i] = "Obese";
            }
        }


        // Printing Result
        for(int i = 0; i < num; i++)
        {
            Console.WriteLine($"height of {i + 1} person is {height[i]}\n weight of {i + 1} person is {weight[i]}\n bmi of {i + 1} person is {BMI[i]}\n weight Status of {i + 1} person is {weightStatus[i]}");
        }
    }
}