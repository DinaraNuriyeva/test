﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            DirectoryInfo di = new  DirectoryInfo(@" C:\Program Files\Git");
            DirectoryInfo[] dirs = di.GetDirectories();

            foreach(DirectoryInfo d in dirs)
            {
                Console.WriteLine(d.Name);
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            FileInfo[] files = di.GetFiles();
            foreach(FileInfo f in files)
            {
                Console.WriteLine(f.Name);
            }


            Console.ReadKey();


        }
    }
}
