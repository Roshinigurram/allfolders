using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace newproject_11dec
{
    class Class9
    {
        
            public void Cancellation()
            {
                ParallelOptions po = new ParallelOptions();
                CancellationTokenSource cts = new CancellationTokenSource();
                po.MaxDegreeOfParallelism = 2;
                po.CancellationToken = cts.Token;
                Task task = Task.Factory.StartNew(() => {
                    if (Console.ReadKey().KeyChar == 'c')
                        cts.Cancel();
                });
                try
                {
                    for (int i = 0; i < 100000; i++)
                    {
                        Console.WriteLine("Task:" + i);
                        po.CancellationToken.ThrowIfCancellationRequested();
                    }
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
                Console.ReadKey();
            }


       
        }
    }



   



    

