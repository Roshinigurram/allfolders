using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number 1:");
            string a = Console.ReadLine();
            Console.WriteLine("enter number 2:");
            string b = Console.ReadLine();

            var add1= add(int.Parse(a), int.Parse(b));


            // Console.WriteLine("The addition of two numbers  is :"  +add1);
            Console.WriteLine($"thes sum of {a} and {b} is  {add1}");
           
        }
        public static int add(int a, int b)
        {
            return a + b;
        }
    }
}
