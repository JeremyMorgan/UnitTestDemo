using System;
using NUnitTests;

namespace ManualTest
{
    class Program
    {

        static void Main(string[] args)
        {
            // this is a "manual" test to check values programatically. 
            // ugly, ugly, ugly


            Calculator ourCalc = new Calculator();
            double n1 = 2;
            double n2 = 4;
            double addTestExpected = 6;
            double subTestExpected = -2;
            double mulTestExpected = 8;
            double divTestExpected = .5;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Addition Test:");
            double result = ourCalc.Add(n1, n2);
            Console.WriteLine("Should be " + addTestExpected + "\nAnswer is " + result);
            if (result == addTestExpected)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Test Passed" + "\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Test Failed" + "\n");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Subtraction Test:");
            result = ourCalc.Subtract(n1, n2);
            Console.WriteLine("Should be " + subTestExpected + "\nAnswer is " + result);

            if (result == subTestExpected)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Test Passed" + "\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Test Failed" + "\n");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Multiplication Test:");
            result = ourCalc.Multiply(n1, n2);
            Console.WriteLine("Should be " + mulTestExpected + "\nAnswer is " + result);

            if (result == mulTestExpected)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Test Passed" + "\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Test Failed" + "\n");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Division Test:");
            result = ourCalc.Divide(n1, n2);
            Console.WriteLine("Should be " + divTestExpected + "\nAnswer is " + result);

            if (result == divTestExpected)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Test Passed" + "\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Test Failed" + "\n");
            }

            // for the pause to read it
            Console.ReadLine();
        }
    }
}
