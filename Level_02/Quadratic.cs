using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Methods.Level_02
{
    internal class Quadratic
    {
        /*
Write a program Quadratic to find the roots of the equation ax2+ bx + c. Use Math
functions Math.pow() and Math.sqrt()
Hint =>
a. Take a, b, and c as input values to find the roots of x.
b. The roots are computed using the following formulae
delta = b2+ 4*a*c
If delta is positive the find the two roots using formulae
root1 of x = (-b + delta)/(2*a)
root1 of x = (-b - delta)/(2*a)
If delta is zero then there is only one root of x
root of x = -b/(2*a)
If delta is negative return empty array or nothing
c. Write a Method to find find the roots of a quadratic equation and return the roots
         */
        public void FindRoots(int a, int b, int c)
        {
            double delta = Math.Pow(b, 2) + 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("No roots");
                return;
            }
            else if(delta == 0)
            {
                double root = -b / (2 * a);
                Console.WriteLine("This eq. has only one root: " + root);
            }
            else
            {
                double root1 = (-b + delta) / (2 * a);
                double root2 = (-b - delta) / (2 * a);
                Console.WriteLine("This eq. has two roots: " + root1 +" and "+root2);

            }
        }
    }
}
