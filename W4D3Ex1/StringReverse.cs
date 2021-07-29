using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4D3Ex1
{
    class StringReverse
    {
        public static void ReverseString()
        {
            Console.WriteLine("Lets create a secret password that has to be read backward!");
            Console.WriteLine("Please enter desired password: ");
            string myString = Console.ReadLine();
            char[] myArray = myString.ToCharArray();
            string reverseString = String.Empty;
            for(int i = myArray.Length -1; i > -1; i--)
            {
                reverseString += myArray[i];
            }
            Console.WriteLine("Passcode is reversing itself...");
            Console.WriteLine($"Reversed order passcode is: {reverseString}");
        }
    }
}


//3.) String in reverse order

//Given a string, write a method that returns that string in reverse order.

//Expected input and output

//StringInReverseOrder("qwerty") → "ytrewq" StringInReverseOrder("oe93 kr") → "rk 39eo"