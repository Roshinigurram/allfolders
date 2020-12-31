using System;
using System.Collections.Generic;
using System.Text;

namespace project
{
    class Class1
    {
        public void MyMethod()
        {
            ////switch case//////////
            Console.WriteLine("enter number");
            int id = int.Parse(Console.ReadLine());
            switch (id)
            {
                case 1:
                    Console.WriteLine("monday");
                    break;
                case 2:
                    Console.WriteLine("tuesday");
                    break;
                case 3:
                    Console.WriteLine("wednesday");
                    break;
                case 4:
                    Console.WriteLine("thursday");
                    break;
                case 5:
                    Console.WriteLine("friday");
                    break;
                case 6:
                    Console.WriteLine("saturday");
                    break;
                case 7:
                    Console.WriteLine("sunday");
                    break;
                default:
                    Console.WriteLine("please enter correct option");
                    break;




            }


            ///////for loop////////
            Console.WriteLine("enter number n");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine($"the sum is {sum}");


            ////if ,else if,else
            Console.WriteLine("enter number1");
            int number1= int.Parse(Console.ReadLine());
            Console.WriteLine("enter number2");
            int number2 = int.Parse(Console.ReadLine());
            if (number1==number2)
            {
                Console.WriteLine($"{number1} is EQUAL to {number2} ");
            }
            else if (number1< number2)
            {
                Console.WriteLine($"{number1} is less than {number2} ");
            }
            else
                Console.WriteLine($"{number1} is greator than {number2}");

            ///try with three catches
            ///
        }
            public void ErrorHandling()
            {
                int i = 5;
                int j = 0;
                try
                {
                    int k = i / j;
                }
                catch (DivideByZeroException ee)
                {
                    Console.WriteLine("Divide by zero exception occured. " + ee.ToString());
                    
                }
                catch (NullReferenceException ee)
                {
                    Console.WriteLine(ee.ToString());
                }
                catch (Exception ee)
                {
                    Console.WriteLine( ee.ToString());
                    
                }


            }
        

     }



    
}

