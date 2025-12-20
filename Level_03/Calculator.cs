using System;

namespace CSharp_Control_Flows.Level_03
{
    internal class Calculator
    {
        public void Calci()
        {
            Console.WriteLine("enter the first number:");
            double first = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the second number:");
            double second = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the sign to perfrom that operation:");
            string op = Console.ReadLine();

            double result = 0;

            switch(op){
                case "+":
                    result = first + second;
                    Console.WriteLine(result);
                    break;

                case "-":
                    result = first - second;
                    Console.WriteLine(result);
                    break;

                case "*":   
                    result = first * second; 
                    Console.WriteLine(result);
                    break;

                case "/":   
                    result = first / second;
                    Console.WriteLine(result);
                    break;

                default:
                    Console.WriteLine("Invalid Operator");
                    break;

            }
        }
    }
}
