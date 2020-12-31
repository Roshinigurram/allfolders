using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace myproject
{
    class task3
    {
        public void GetSubDirectories()

        {
            Console.WriteLine("enter directory name");
            string root = Console.ReadLine();
            // Get all subdirectories

            string[] subdirectoryEntries = Directory.GetDirectories(root);

            // Loop through them to see if they have any other subdirectories

            //Parallel.For( 0, subdirectoryEntries.Length, i =>
            //    {
            //        var g = subdirectoryEntries[i];
            //        Console.WriteLine(g);

            //});
            //{ }
            foreach (string subdirectory in subdirectoryEntries)

                LoadSubDirs(subdirectory);

        }

        private void LoadSubDirs(string dir)

        {

            Console.WriteLine(dir);

            string[] subdirectoryEntries = Directory.GetDirectories(dir);

            foreach (string subdirectory in subdirectoryEntries)

            {

                LoadSubDirs(subdirectory);

            }

        }
    }
}
