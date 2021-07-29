using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4D3Ex1
{
    class NumberSort
    {
        public static void BigNum()
        {
            Console.WriteLine("We are given the numbers...190 , 291 , 145 , 209 , 280 , 300");
            Console.ReadLine();
            Console.WriteLine("Take a guess at which number is the biggest =D");
            Console.ReadLine();
            Console.WriteLine("Got your number? press enter when ready!");
            Console.ReadLine();
            int[] arr = { 190, 291, 145, 209, 280, 300 };
            for (int i = 0; i < arr.Length; i++)
            {
                int bigNumber = arr.Max();
                if (arr[i] >= bigNumber)
                {
                    Console.WriteLine("Lets see if you're right...");
                    Console.WriteLine($"The biggest number is: {bigNumber}");
                }

            }
            Console.WriteLine("Now.. Lets try manual input :)");
            Console.WriteLine("Please type in how many numbers you would like to input: ");
            int[] newArr;
            int size = Int32.Parse(Console.ReadLine());
            newArr = new int[size];
            int bigNum = newArr.Max();
            Console.WriteLine($"Please enter your numbers...");

            for (int i = 0; i < newArr.Length; i++)
            {
                Console.WriteLine($"Element[ {i} ]:");
                newArr[i] = Int32.Parse(Console.ReadLine());
            }
            for (int i = 0; i < newArr.Length; i++)
            {
                if (bigNum < newArr[i])
                    bigNum = newArr[i];
            }
            Console.WriteLine($"The Largest Number is {bigNum}");
        }
    }
}
//4.) Given an array of integers, write a method that returns the biggest number in this array.

//Expected input and output

//TheBiggestNumber([190, 291, 145, 209, 280, 300]) → 300 TheBiggestNumber([-9, -2, -7, -8, -4]) → -2

//Create Array
//