using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Multithreading_FileApp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            MoveFiles f1 = new MoveFiles();
            DeleteFiles f2 = new DeleteFiles();

            Thread t1 = new Thread(f1.Move_files);
            t1.Start();
            Console.WriteLine("Files moved to their respective folders.");

            Thread t2 = new Thread(f2.DeleteImages);
            Thread t3 = new Thread(f2.DeleteText);
            Thread t4 = new Thread(f2.DeleteVideos);
            t2.Start();
            t3.Start();
            t4.Start();

            Console.ReadLine();
        }
    }
}
