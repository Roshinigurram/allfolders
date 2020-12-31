using System;
using System.Collections.Generic;
using System.Text;

namespace ADO.NET
{
    class InsertRecordsIntoStudentList
    {
        public void Execute()
        {
            try
            {
                using(var context=new CompanyContext() )
                {
                    var student = new studentDetails
                    {
                         StudentName = "roshini",
                         grade = "A",
                         section="b12"
                    };
                    context.studentDetailsList.Add(student);
                    context.SaveChanges();
                    Console.WriteLine("heheheheheheheh");
                }
                

            }
            catch (Exception)
            {

                Console.WriteLine("some error has occured" );
            }
        }
    }
}
