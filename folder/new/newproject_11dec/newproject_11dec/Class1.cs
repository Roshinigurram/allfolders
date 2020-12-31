using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace newproject_11dec
{
    class Class1
    {
       public void myfilescreation()
        {
            
                Console.WriteLine("enter file name");
                var fname = Console.ReadLine();
                var path = Path.Combine(@"D:\practise", fname);
                FileStream fs = File.Create(path);
                TextWriter tw = new StreamWriter(fs);
            
                var content = Console.ReadLine();

                tw.WriteLine(content);
                tw.Close();
                tw.Dispose();
                fs.Close();
                fs.Dispose();
            }
            
            

            
    }
}
