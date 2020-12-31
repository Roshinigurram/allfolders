using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace project
{
    class Class7
    
    {
            public  void Mastermethod()
            { 
                Console.WriteLine("name your File:");
                var FileName = Console.ReadLine();
                Console.WriteLine("Enter content in your file: ");
                var FileContent = Console.ReadLine();
                var FilePath = System.IO.Path.Combine(Environment.CurrentDirectory, FileName);
                File.WriteAllText(FilePath, FileContent);

                Console.WriteLine("Content in your file is");
                var CompleteFile = File.ReadAllText(FilePath);
                Console.WriteLine(CompleteFile);

    

            }



        
    }
}


