using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
             static int Add( int a, int b)
            {

               
                return a + b;
            }
        

            // call method that returns value    
            //int a = 5;       
            //int b = 6;        
            int sum = Add(a:7,b:6);
            Console.WriteLine(sum.ToString());//16
           // Console.WriteLine(a.ToString()); // 10 

            

        }
    }
}
