using System;

namespace ADO.NET
{
    class Program
    {

        static void Main(string[] args)
        {
            //InsertRecordUsingSQLQuery insertRecordUsingSQLQuery = new InsertRecordUsingSQLQuery();
            // insertRecordUsingSQLQuery.execute();
            //task1
            // ReadEmpDetails readEmpDetails = new ReadEmpDetails();
            // readEmpDetails.Execute();
            //task2
            //Console.Write("Enter employee number to read details:");
            //var employeeid = int.Parse(Console.ReadLine());
            //Class2 class2 = new Class2();
            //class2.ReadEmpById(employeeid);
            //task3
            //Class3 class3 = new Class3();
            //Console.WriteLine("enter employee id to display employee name");
            //var employeeid1 = int.Parse(Console.ReadLine());
            //var name = class3.GetEmpNameById(employeeid1);
            //Console.WriteLine(name);
            //task4
            // Class4 class4 = new Class4();
            // class4.Execute();

            //Class5 class5 = new Class5();
            // class5.LinqExtensionMethods();
            InsertRecordsIntoStudentList insertRecordsIntoStudentList = new InsertRecordsIntoStudentList();
            insertRecordsIntoStudentList.Execute();


        }
    }
}
