using System;
using System.Collections.Generic;
using System.Text;

namespace ADO.NETEF
{
    class InsertRecordsIntoProducts
    {
        public void Execute()
        {
            try
            {

                using (var context = new CompanyContext())
                {
                    Console.WriteLine("enter the number of records to be entered");
                    int n = int.Parse(Console.ReadLine());

                    for (int i = 0; i < n; i++)
                    {

                        var prod = new ProductsNew
                        {
                            ProductID = int.Parse(Console.ReadLine()),
                            ProductName = Console.ReadLine(),
                            Cost = int.Parse(Console.ReadLine()),
                            Orderid = int.Parse(Console.ReadLine())

                        };
                        context.Products.Add(prod);
                        context.SaveChanges();


                    }
                }
            }


            catch (Exception ex)
            {
                Console.WriteLine("something has occured" + ex.Message);
            }
        }

    }
}

