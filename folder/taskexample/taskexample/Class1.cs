using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;



namespace taskexample
{
    class Class1
    {
       
        public void myMethod()
        {
            string s1 = "roshini";
            Console.WriteLine(s1);
            s1 = "sreeja";//creats new object s1 if string is used
            Console.WriteLine(s1);
            StringBuilder sr = new StringBuilder("geethika");
            Console.WriteLine(sr);
            sr = new StringBuilder("karthik");//adds in the same object doesnot create new object
            Console.WriteLine(sr);
        }
    }
}
