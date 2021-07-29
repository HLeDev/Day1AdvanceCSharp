using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4D3Ex1
{
    class ReturnEvenNums
    {
        public static void ReturnEvenNumbers()
        {

            Console.WriteLine("Lets find our even numbers, please enter a number...");
            int evenArr = Int32.Parse(Console.ReadLine());
            for (int i = 2; i < evenArr; i = i+2) // i starts at 2, will go until 99, i +2 every time
            {
                Console.Write(i + " "); //Caling i with " " put a space in between numbers
            }
        }
    }
}



//ReturnEvenNumbers() → "2 4 6 8 10 12 14 16 18 20 22 24 26 28 30 32 34 36 38 40 42 44 46 48 50 52 54 56 58 60 62 64 66 68 70 72 74 76 78 80 82 84 86 88 90 92 94 96 98"