using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace myproject
{
    class Class1
    {
        public void GetSub()

        {

            string root = @"D:\roshini";

            // Get all subdirectories

            string[] subdirectoryEntries = Directory.GetDirectories(root);

            // Loop through them to see if they have any other subdirectories

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
