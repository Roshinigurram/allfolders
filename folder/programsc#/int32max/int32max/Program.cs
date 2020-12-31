using System;
using System.Collections.Generic;

namespace int32max
{
    class Program
    {
        static void Main(string[] args)
        {

            SortedList<string> sList = new SortedList<int, string>();
            sList.Add( "Hii");
            sList.Add("Helloo");
            sList.Add( "France");
            sList.Add( "Disney");
            sList.Add( "Voldmort");
            sList.Add( "Harry potter");
            sList.Add("Hermoine");
            Console.WriteLine("~~~~~~~~~~~~~~~~");
            foreach (var kp in sList)
            {
                Console.WriteLine("Key:{0}, Value:{1}", kp.Key, kp.Value);
            }
        }
    }
}


