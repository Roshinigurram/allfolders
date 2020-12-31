using System;
using System.Collections.Generic;
using System.Text;

namespace newproject_11dec
{
    class class8
    {
        public void myList()
        {
            Dictionary<string, string> mydict = new Dictionary<string, string>();
            mydict.Add("3", "roshini");
            mydict.Add("2", "geethika");
            mydict.Add("1", "sreeja");
            foreach (var item in mydict)
            {
                Console.WriteLine($"{ item.Key},{ item.Value}");
            }
            SortedList<int, string> mylist = new SortedList<int, string>();
            mylist.Add(6, "hey");
            mylist.Add(2, "helo");
            mylist.Add(8, "how r u");
            foreach (var item1 in mylist)
            {
                Console.WriteLine($"{ item1.Key},{ item1.Value}");
            }

            int[] arr = new int[3];
            arr[0] =2;
            arr[1] = 3;
            arr[2] = 10;
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }


        }

    }
}
