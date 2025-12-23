//10.Create a program to divide N number of chocolates among M children. Print the number
//of chocolates each child will get and also the remaining chocolates

using System;

internal class ChocolateDivide
{
    internal static void Divide(int student, int chocolate)
    {
        // finding the chocolate per person
        Console.WriteLine($"chocolate per person is {chocolate % student} and remaining left chocolates are {chocolate / student}");
        
    }

    internal static void Find()
    {
        // taking inputs of total students and chocolates needed.
        Console.WriteLine("enter the no. of students:");
        int.TryParse(Console.ReadLine() ?? "", out int student);

        Console.WriteLine("enter the no. of chocolate:");
        int.TryParse(Console.ReadLine() ?? "", out int chocolate);


        // method call
        Divide(student,chocolate);
    }
}