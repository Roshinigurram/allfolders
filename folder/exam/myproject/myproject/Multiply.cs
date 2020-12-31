using System;
using System.Collections.Generic;
using System.Text;

namespace myproject
{
    public class Multiply
    {
        public void Mul()
        {
            //int table, j, result;
            //table = 12;
            //j = 1;
            //do
            //{
            //    result = table * j;
            //    Console.WriteLine("{0} x {1} ={2}", table, j, result);
            //    j++;
            //} while (j <= 10);
            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine($"{n}x{i}={n*i}" );
            }
        }
    }
}
