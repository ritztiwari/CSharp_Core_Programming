//Create a program to find the bonus of 10 employees based on their years of service and the
//total bonus amount the company Zara has to pay, along with the old and new salary.

using System;

public class EmployeesBonus
{
    public void NewBonus()
    {
        Console.WriteLine("Starting");
        const int n = 10;
        double[] salary = new double[n];
        double[] experience = new double[n];

        Console.WriteLine("inputs");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"enter the salary for {i+1} Employee");
            string input1 = Console.ReadLine();

            Console.WriteLine($"enter the experience for {i+1} Employee");
            string input2 = Console.ReadLine();


            double.TryParse(input1, out double value1);
            double.TryParse(input1, out double value2);

            salary[i] = value1;
            experience[i] = value2;
        }

        double newTotalBonus = 0;
        double oldTotalSalary = 0;
        double[] newSalary = new double[n];
        //double oldTotalBonus = 0;

        double newBonus = 0;

        for (int i = 0; i < n; i++)
        {

            if (experience[i] >= 5)
            {
                newBonus = 0.05 * salary[i];
            }
            else
            {
                newBonus = 0.02 * newSalary[i];

            }

            oldTotalSalary += salary[i];
            newSalary[i] = salary[i] + newBonus;
            newTotalBonus += newBonus;
        }

        Console.WriteLine("print the salary");
        Console.WriteLine(string.Join(",", salary));

        Console.WriteLine("print the new salary");
        Console.WriteLine(string.Join(",", newSalary));

        Console.WriteLine("print old total salary");
        Console.WriteLine(oldTotalSalary);

        Console.WriteLine("print new total bonus");
        Console.WriteLine(newTotalBonus);

    }
}


