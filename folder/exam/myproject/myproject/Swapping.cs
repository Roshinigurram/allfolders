using System;
using System.Collections.Generic;
using System.Text;

namespace myproject
{
    class Swapping
    {
        public void myMethod()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"before swapping a:{a} b:{b}");
            swapTwo(ref a, ref b);
            Console.WriteLine($"After swapping a:{a} b:{b}");
        }

        private static void swapTwo(ref int a, ref int b)
        {

            int temp;
            temp = a;
            a =  b;
            b = temp;
        }
    }
}
