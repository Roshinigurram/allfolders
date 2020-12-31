using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace myproject
{
    class files
    {
        //
        public void myFileMethod()
        {
            Console.WriteLine("enter file name");
            var fileName = Console.ReadLine();
            var path = Path.Combine(System.Environment.CurrentDirectory, fileName);
            FileStream fs = File.Create(path);
            TextWriter tw = new StreamWriter(fs);
            //task1&2//create new file with some content
            tw.WriteLine("my file is created");
            //read content from .txt file and should be displayed in output
            Console.WriteLine("enter content");
            var content = Console.ReadLine();
            tw.WriteLine(content);
            tw.Close();
            tw.Dispose();
            fs.Close();
            fs.Dispose();

        }
    }
}
