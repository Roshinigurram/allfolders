using System;
using System.Collections.Generic;
using System.Text;

namespace project
{
    public class Class2
    {
        
        //method overloading
            public int add(int num1, int num2)
            {
                return num1 + num2;
            }
            public int add(int num1, int num2, int num3)
            {
                return num1 + num2 + num3;
            }
        
        //method overrrriding
        public virtual string MyName()
        {
            return "roshini";
        }
       
    }
}
