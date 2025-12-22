using System;

class StudentMarks1D
{
    public void Marks()
    {
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine() ?? "0");

        double[] physics = new double[n];
        double[] chemistry = new double[n];
        double[] maths = new double[n];
        double[] percentage = new double[n];
        string[] grade = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Student {i + 1}");

            if (!ReadPositiveMark("Physics", out physics[i])) { i--; continue; }
            if (!ReadPositiveMark("Chemistry", out chemistry[i])) { i--; continue; }
            if (!ReadPositiveMark("Maths", out maths[i])) { i--; continue; }

            percentage[i] = (physics[i] + chemistry[i] + maths[i]) / 3;
            grade[i] = GetGrade(percentage[i]);
        }

        Console.WriteLine("\nResults:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Student {i + 1}: Physics={physics[i]}, Chemistry={chemistry[i]}, Maths={maths[i]}, Percentage={percentage[i]:F2}, Grade={grade[i]}");
        }
    }

    static bool ReadPositiveMark(string subject, out double mark)
    {
        Console.Write($"Enter {subject} marks: ");
        if (double.TryParse(Console.ReadLine() ?? "", out mark) && mark >= 0)
            return true;

        Console.WriteLine("Invalid marks. Enter positive values again.");
        mark = 0;
        return false;
    }

    static string GetGrade(double p)
    {
        if (p >= 90) return "A";
        if (p >= 75) return "B";
        if (p >= 60) return "C";
        if (p >= 50) return "D";
        return "F";
    }
}
