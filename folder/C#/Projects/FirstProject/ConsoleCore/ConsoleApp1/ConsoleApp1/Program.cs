using System;
using System.Diagnostics;
using System.Runtime.InteropServices.WindowsRuntime;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============================");
            Console.WriteLine("Sum of two numbers");
            Console.WriteLine("============================");
            Console.WriteLine("Enter first number: ");
            string a = Console.ReadLine();

            Console.WriteLine("Enter second number: ");
            string b = Console.ReadLine();

            var sum = Sum(int.Parse(a), int.Parse(b));

            Console.WriteLine("The sum of " + a + " and " + b + " is: " + sum);

            Console.ReadKey();
        }

        private static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
