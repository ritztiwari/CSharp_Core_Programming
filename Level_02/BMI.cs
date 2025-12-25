using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Methods.Level_02
{
    internal class BMI
    {
        /*
An organization took up the exercise to find the Body Mass Index (BMI) of all the
persons in the team of 10 members. For this create a program to find the BMI and display
the height, weight, BMI and status of each individual
Hint =>
a. Take user input in double for the weight (in kg) of the person and height (in cm)
for the person and store it in the corresponding 2D array of 10 rows and 3 columns.
The First Column storing the weight, the second column storing the height in cm and
the third column is the BMI
b. Create a Method to find the BMI of every person and populate the array. Use
the formula BMI = weight / (height * height). Note unit is kg/m^2. For this convert cm
to meter
c. Create a Method to determine the BMI status using the logic shown in the
figure below. and return the array of all the persons BMI Status.
         */
        public void FindBMI(double [,] data )
        {
            for(int i=0; i<data.GetLength(0); i++)
            {
                double weightInKg = data[i,0];
                double heightInCm = data[i, 1];
                double heightInMeters = heightInCm / 100;
                double bmi = weightInKg / (heightInMeters*heightInMeters);
                string bmiStatus = GetStatus(bmi);
                Console.WriteLine($"Person {i + 1} => BMI: {bmi:F2}, Status: {bmiStatus}, weight: {weightInKg}kg and height: {heightInMeters}m");

            }
        }
        public string GetStatus(double bmi)
        {
            if (bmi <= 18.4) return "Underweight";
            else if (bmi >= 18.5 && bmi <= 24.9) return "Normal";
            else if (bmi >= 25.0 && bmi <= 39.9) return "Overweight";
            else return "Obese";
        }
    }
}
