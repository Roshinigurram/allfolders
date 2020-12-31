using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
   public  class menu
    {
        public void calculate()
        {
            Calculator obj = new Calculator();
            int result1 = obj.sum(10, 20);
            Console.WriteLine( "the result is" +result1);
            int result2 = obj.sub(20, 10);
            Console.WriteLine( "the reults is" +result2);
            int result3 = obj.mul(20, 10);
            Console.WriteLine("the reults is" + result3);

        }


    }
}
