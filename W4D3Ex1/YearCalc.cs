using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4D3Ex1
{
    class YearCalc
    {
        public static void LeapYear()
        {
            Console.WriteLine("Lets find out if the year you inputted is a Leap Year... ");
            Console.WriteLine("Please enter your desired year:");
            int year = Int32.Parse(Console.ReadLine());
            if (year % 400 == 0 || (year % 4 == 0 && year % 4 != 0))
                Console.WriteLine("It's a leap year");
            else
                Console.WriteLine("It's not a leap year");
        }
    }
}
