using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace overload
{
    class Class1
    {
        public int Add(int a ,int b)
        {
           return a + b;
            
        }
        public int Add(int a,int b,int c)
        {
            return a + b + c;
            
        }
       public string Add(string a ,string b)
        {
            return a + b;
        }
    }
}
