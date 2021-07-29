using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4D3Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            char yes = 'y';
            while (yes == 'y')
            {
                Console.WriteLine("Welcome to Week 4, Day 3, Assignment 1!");
                Console.WriteLine("Lets completed our assignment from top to bottom!!, please select number of operation");
                Console.WriteLine("1. Our first task is: Return even Numbers that are greater than 0 and less than 100! ");
                Console.WriteLine("2. Our second task is: Typing in a year to find out if it's a Leap Year");
                Console.WriteLine("3. Our third task is : Reversing a string in order");
                Console.WriteLine("4. Our last and final task is: Given an array of integers, return the biggest");
                int choice = Convert.ToInt32(Console.ReadLine());
                //YearCalc.LeapYear();
                //StringReverse.ReverseString();
                //NumberSort.BigNum();

                switch (choice)
                {
                    case 1:
                        ReturnEvenNums.ReturnEvenNumbers();
                        Console.ReadLine();
                        Console.WriteLine("Lets continue...");
                        break;
                    case 2:
                        YearCalc.LeapYear();
                        Console.ReadLine();
                        Console.WriteLine("Lets continue...");
                        break;
                    case 3:
                        StringReverse.ReverseString();
                        Console.ReadLine();
                        Console.WriteLine("Lets continue...");
                        break;
                    case 4:
                        NumberSort.BigNum();
                        Console.ReadLine();
                        Console.WriteLine("Congrats, this is the last task!");
                        break;
                    default:
                        {
                            Console.WriteLine("You typed in an invalid number");
                            break;
                        }
                }
                Console.WriteLine("Would you like to try again?");
                Console.WriteLine("Press Y for Yes and N for No");
                yes = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Application is closing...Please press enter 2x to close");
            Console.ReadLine();
        }
    }
}
