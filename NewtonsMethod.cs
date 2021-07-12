using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramsForNUnitTesting
{
    class NewtonsMethod
    {
        public static void square()
        {
            Console.WriteLine("Enter a positive number :");
            double c = Convert.ToDouble(Console.ReadLine());
            double epsilon = 1.0e-15;  // relative error tolerance
            double t = c;              // estimate of the square root of c

            // repeatedly apply Newton update step until the condition is satisfied
            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = (c / t + t) / 2.0;
            }

            // print out the estimate of the square root of c
            Console.WriteLine(t);



        }
    }
}
    
