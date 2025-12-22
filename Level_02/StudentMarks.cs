//9.Rewrite the above program to store the marks of the students in physics, chemistry, and
//maths in a 2D array and then compute the percentage and grade


using System;

public class StudentMarks
{
    public void Marks()
    {
        Console.WriteLine("enter the number of Students:");
        string input = Console.ReadLine() ?? "";
        long.TryParse(input, out long num);

        int[,] marks = new int[num,3];
        double[] percentage = new double[num];
        char[] grade = new char[num];

        for(int i = 0; i < num; i++)
        {
            Console.WriteLine($"enter the marks for {i+1} student");
            for(int j = 0; j < 3; j++)
            {
                Console.WriteLine($"enter the marks for subject {j+1}:");
                int.TryParse(Console.ReadLine() ?? "", out int mark);
                marks[i, j] = mark;
            }
        }

        // calculating percentage 
        for (int i = 0; i < num; i++)
        {
            double tatalMarksObtained = 0;
            for (int j = 0; j < 3; j++)
            {
                tatalMarksObtained += marks[i,j];
                //Console.WriteLine(tatalMarksObtained);
            }
            double m = (tatalMarksObtained / 300) * 100;
            percentage[i] = m;
            //Console.WriteLine(percentage[i]);
        }


        for (int i = 0; i < num; i++)
        {
            if (percentage[i] > 80)
            {
                grade[i] = 'A';
            }
            else if (percentage[i] >= 70 && percentage[i] <= 79)
            {
                grade[i] = 'B';
            }
            else if (percentage[i] >= 60 && percentage[i] <= 69)
            {
                grade[i] = 'C';
            }
            else if (percentage[i] >= 50 && percentage[i] <= 59)
            {
                grade[i] = 'D';
            }
            else if (percentage[i] >= 40 && percentage[i] <= 49)
            {
                grade[i] = 'E';
            }
            else
            {
                grade[i] = 'R';
            }
        }

        Console.WriteLine("\nresult declaration\n");
        for(int i=0;i<num;i++)
        {
            int j = 0;
            while(j < 3)
            {
                Console.WriteLine($"marks for physics: {marks[i, j]}");
                j++;

                Console.WriteLine($"marks for chemistry: {marks[i, j]}");
                j++;

                Console.WriteLine($"marks for maths: {marks[i, j]}");
                j++;
            }
            Console.WriteLine($"total percentage obtained by {i} is {percentage[i]:F2}");
            Console.WriteLine($"total grade for student {i} is {grade[i]}\n");
        }

    }
}