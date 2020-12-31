using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace parallelprogrammin
{
    public class Class3
    {
        public void taskprogram()
        {
            Console.WriteLine($"Main thread {Thread.CurrentThread.ManagedThreadId} has started");
            Task task = new Task(mymethod);
            Console.WriteLine($"Main thread {Thread.CurrentThread.ManagedThreadId} has started");
            Task task1 = new Task(myexample);
            Console.WriteLine($"Main thread {Thread.CurrentThread.ManagedThreadId} has started");
            task.Start();
            task.Wait();
            Console.WriteLine($"Main thread {Thread.CurrentThread.ManagedThreadId} has ended");

        }

        private void myexample()
        {
            int i;
            for(i=0;i<100;i++)
            {
                
                Console.WriteLine($" counter {i}");
            }
        }

        private void mymethod()
        {
            int i;

            for (i = 0; i < 1000; i++)
            {
                Console.WriteLine($"Counter {i}");
            }
        }
    }
}
