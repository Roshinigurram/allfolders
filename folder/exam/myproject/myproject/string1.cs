using System;
using System.Collections.Generic;
using System.Text;

namespace myproject
{
    class string1
    {
        public void strMethod()
        {
            Console.WriteLine("enter string");
            string str = Console.ReadLine();
            Console.WriteLine("enter index to be removed at");
            int i = int.Parse(Console.ReadLine());
            string string1 = str.Remove(i, 1);
            Console.WriteLine("after removal at a particular index");
            Console.WriteLine( string1);
          
        }
    }
}
