using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace task2
{
    class Class1
    {
        public void getDirector()
        {
           
            Console.WriteLine("Enter path");
            var path = Console.ReadLine();

            var dirInfo = new DirectoryInfo(path);

            foreach (FileInfo fi in dirInfo.GetFiles("*", SearchOption.AllDirectories))
            {
                Console.WriteLine(fi.FullName + "\t" + fi.Length);
            }
        }
    }
}
