using System;
using System.Collections.Generic;
using System.Text;

namespace myproject
{
    class Class5
    {
       public void reverseString(string str)
        {

           
            var s = new StringBuilder();
            s.Append(str);

            var tmp = s[0];
            s[0] = s[s.Length - 1];
            s[s.Length - 1] = tmp;

            str = s.ToString();
            Console.WriteLine(str);
        }

    }
}
