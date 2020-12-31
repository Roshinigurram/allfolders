using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace parallelprogrammin
{
    class Class1
    {
        public void EnumerateWithOrder()
        {
            IEnumerable<int> mylist = Enumerable.Range(0, 10);
            var mynumbers = from n in mylist.AsParallel().AsOrdered()
                            select n;
            foreach (int i in mynumbers)
            {
                Console.WriteLine(i.ToString());
            }
        }


        public void EnumerateWithOutOrder()
        {
            IEnumerable<int> mylist2 = Enumerable.Range(1, 1000);
            var mynumbers = from n in mylist2.AsParallel().WithDegreeOfParallelism(2)
                            select n;
            foreach (int i in mynumbers)
            {
                Console.WriteLine(i.ToString());
            }
        }
        public void StoppingParallelProcessingInBetween()
        {
            var cts = new CancellationTokenSource();

            // Use ParallelOptions instance to store the CancellationToken
            ParallelOptions po = new ParallelOptions();
            po.CancellationToken = cts.Token;
            po.MaxDegreeOfParallelism = 5;

            Console.WriteLine(" Press 'c' to cancel.");
            // Run a task so that we can cancel from another thread.
            Task.Factory.StartNew(() =>
            {
                if (Console.ReadKey().KeyChar == 'c')
                    cts.Cancel();
                Console.WriteLine("\nPress any key to exit");
                // cts.Cancel();
            });

            IList<string> invoices = new List<string>();
            // populate invoice data
            for (var i = 0; i < 100; i++)
            {
                invoices.Add("Invoice " + i);
            }

            try
            {
                Parallel.ForEach(invoices, po, invoice =>
                {
                    Console.WriteLine(invoice + " processing with thread " + Thread.CurrentThread.ManagedThreadId);
                    System.Threading.Thread.Sleep(1000);
                    po.CancellationToken.ThrowIfCancellationRequested();
                });
            }
            catch (OperationCanceledException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.ToString());
            }

            Console.WriteLine("Waiting to exit, press any key.");
            Console.Read();
        }
        //public void BreakOrStopParallelLoop()
        //{
        //    // Use ParallelOptions instance to store thread count
        //    ParallelOptions po = new ParallelOptions();
        //    po.MaxDegreeOfParallelism = 5;

        //    IList<string> invoices = new List<string>();
        //    // populate invoice data
        //    for (var i = 0; i < 10; i++)
        //    {
        //        invoices.Add("Invoice " + i);
        //    }

        //    Parallel.ForEach(invoices, po, (invoice, loopState) =>
        //    {
        //        try
        //        {
        //            // Do some work
        //            Console.WriteLine(invoice + " processing with thread " + Thread.CurrentThread.ManagedThreadId);
        //            if (invoice.Equals("Invoice 5"))
        //            {
        //                // visit https://stackoverflow.com/questions/12571048/break-parallel-foreach for more details explanations between Break and Stop
        //                // Completes all iterations of all threads that are prior to the 
        //                // current iterations and then exit the loop
        //                loopState.Break();

        //                // Stop all iterations as soon as convenient
        //                loopState.Stop();
        //                // throw new ArgumentException("Error occured at 5");
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex);

        //            //System.Threading.Thread.Sleep(5000);

        //        }

        //    });

        //    Console.WriteLine("Waiting to exit, press any key.");
        //    Console.Read();
        //}

    }
}
