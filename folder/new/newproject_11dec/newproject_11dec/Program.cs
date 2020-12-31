using System;

namespace newproject_11dec
{
    class Program
    {
        static void Main(string[] args)
        {
            //abstract class implmentation
                  Class2_1 class2_1 = new Class2_1();
                  class2_1.mymethod();
           // constructor
                  Constructordemo constructordemo = new Constructordemo(5, 6);
            //extension method
                  forExtension ob = new forExtension();
                  ob.add(12,45);
                  ob.sub(12, 9);
                   ob.Mul();
            //interface 
            implementation implementation = new implementation();
            implementation.myInterface();
            //dictionary//sortedlist//array
            class8 class8 = new class8();
            class8.myList();
            //method overloading
            Class8_1 class8_1 = new Class8_1();
            class8_1.add(12, 22);
            class8_1.add(12, 22, 122);
            class8_1.add("lali", "tha");
            //method overriding
            Class8_3 class8_3 = new Class8_3();
            
            class8_3.myName();
            //collection of class 
           //classlist classlist = new classlist();
            //classlist.mymain();
            //cancellation
            //Class9 class9 = new Class9();
            //class9.Cancellation();
            int i = 10;
            object j = i;
            Console.WriteLine(j);
            int k = (int)j;
            Console.WriteLine(k);
            Class1 class1 = new Class1();
            class1.myfilescreation();


        }
    }
}
