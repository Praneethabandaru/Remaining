using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace HandlingFiles
{
    internal class assign
    {
        public void demo1()
        {
            string path = @"C:\mydirectory\hello.txt";
            if(Directory.Exists(path))
            {
                string[] dir = Directory.GetFiles(path);
                if(dir.Length ==0)
                {
                    Console.WriteLine("no files");
                }
                else
                {
                    Console.WriteLine("files are present");
                    foreach (string s in dir)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
        }
    }
}
