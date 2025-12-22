//Create a program to find the youngest friends among 3 Amar, Akbar, and Anthony based on
//their ages and the tallest among the friends based on their heights

using System;

public class Youngest_Tallest
{
    public void Find()
    {
        const int n = 3;
        int[] age = new int[n];
        double[] height = new double[n];

        Console.WriteLine("input of age");

        for(int i = 0; i < age.Length; i++)
        {
            string input = Console.ReadLine();
            int.TryParse(input, out age[i]);
            
        }

        Console.WriteLine("input of height");
        
        for(int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            double.TryParse(input, out height[i]);
        }


        int youngest = 200;
        double tallest = 0;
        int k = 0;
        int l = 0;

        for(int i = 0; i < age.Length; i++)
        {
            if(youngest > age[i])
            {
                youngest = age[i];
                k = i;
            }

            if(tallest < height[i])
            {
                tallest = height[i];
                l = i;
            }
        }

        Console.WriteLine($"youngest person is {youngest}");
        Console.WriteLine($"tallest person is {tallest}");

    }
}


