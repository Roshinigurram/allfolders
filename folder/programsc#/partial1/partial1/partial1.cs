using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace partial1
{
    public class partial1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number1");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number2");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Cond(a, b));
            Program obj = new Program();
            obj.Cond();



        }
    }
}
