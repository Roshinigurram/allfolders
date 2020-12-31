using System;
using System.IO;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter file name");
            var fname = Console.ReadLine();

            var path = Path.Combine(@"D:\task", fname);
            FileStream fs = File.Create(path);
            TextWriter tw = new StreamWriter(fs);
            tw.WriteLine("iam writing in file");
            var content = Console.ReadLine();
            tw.WriteLine(content);
            var text = File.ReadAllText(fname);
            Console.WriteLine(text);
            tw.Close();
            tw.Dispose();
            fs.Close();
            fs.Dispose();
            // directoryGet obj = new directoryGet();
            // obj.getFullDirectories();
            Class1 class1 = new Class1();
           class1.getDirector();



        }
        
       
    }
}
