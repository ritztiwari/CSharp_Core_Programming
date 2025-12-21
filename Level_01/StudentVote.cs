using System;

public class StudentVote
{
    public void Vote()
    {
        int n = 10;
        int[] student = new int[n];

        for (int i = 0; i < n; i++)
        {
            student[i] = Convert.ToInt32(Console.ReadLine());
        }

        foreach(int i in student)
        {
            if(i > 18)
            {
                Console.WriteLine($"the student with the age {i} can Vote");
            }
            else
            {
                Console.WriteLine($"the student with the age {i} cannot Vote");
            }
        }
    }
}