using System;
using System.Threading.Tasks;
using System.Threading;

namespace threadexample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("main method started");
            Thread t1 = new Thread(() =>method1() );
            Thread t2 = new Thread(() => method2());
            Thread t3=new Thread(()=> method3());
            t1.Start();
            //Thread.Sleep(5000);
            t2.Start();
            //Thread.Sleep(3000);
            t3.Start();
            //Thread.Sleep(2000);
            //t1.Join();
            //t2.Join();
            //t3.Join();
            t1.Abort();

            Console.WriteLine("main method has ended");



        }

        public static void method1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("task1" + i);
            }

        }
        public static void method2()
        {
            for(int i=0;i<50;i++)
            {
                Console.WriteLine("count2" +i);
            }
        }
        public static void method3()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine("program3" + i);
            }
        }
    }
}
