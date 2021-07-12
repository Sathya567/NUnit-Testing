using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramsForNUnitTesting
{
    class MonthlyPayment
    {
        public static void pay()
        {
            int P, Y, R;
            Console.WriteLine("Enter the year");
            Y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the P");
            P = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Rate");
            R = int.Parse(Console.ReadLine());
            int n = 12 * Y;
            int r = R / (12 * 100);
            int payment = P * r / 1 - (1 + r) ^ (-n);
            Console.WriteLine("Monthly Payment is" + payment);

        }

    }
}
    
