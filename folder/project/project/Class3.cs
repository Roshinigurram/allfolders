using System;
using System.Collections.Generic;
using System.Text;

namespace project
{
    public class Class3
    {
        public void MyMethod()
        {
            int n1 = int.Parse(Console.ReadLine());

            if(n1%2==0)
            {
                Console.WriteLine("the number is even");
            }
            else
                Console.WriteLine("the number is not even");
        }
    }
}
