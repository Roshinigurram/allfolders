using System;
using System.Collections.Generic;
using System.Text;

namespace myproject
{
    class Class2
    {
        public void myAverage()
        {
            float sum = 0,average;
                int[] num = new int[4];

            for(int i=0;i<num.Length;i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
                sum +=  num[i];

            }
            average = sum / 4;
            Console.WriteLine(average);

        }
    }
}
