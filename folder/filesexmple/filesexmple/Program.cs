using System;
using System.IO;

namespace filesexmple
{
    class Program
    {
        static void Main(string[] args)
        {

            
                // create a writer and open the file
                TextWriter tw = new StreamWriter("myfilenew.txt");

          // TextReader tw = new StreamReader("myfile.txt");
            //Console.WriteLine(tw.ReadLine());
            
            // write a line of text to the file
           tw.WriteLine("THE TIME IS");
                tw.WriteLine(DateTime.Now);

                // close the stream
                tw.Close();
            }

    }


}


