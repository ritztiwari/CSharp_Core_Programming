// Write a program SpringSeason that takes two int values month and day
// and prints “Its a Spring Season” otherwise prints “Not a Spring Season”.

using System;

internal class SpringSeasonOrNot
{
    // method to check spring season
    internal static void CheckSpringSeason(int month, int day)
    {
        bool isSpring =
            (month == 3 && day >= 20) ||
            (month == 4) ||
            (month == 5) ||
            (month == 6 && day <= 20);

        if (isSpring)
        {
            Console.WriteLine("Its a Spring Season");
        }
        else
        {
            Console.WriteLine("Not a Spring Season");
        }
    }
}
