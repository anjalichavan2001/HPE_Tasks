using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Multithreading_FileApp
{
    class DeleteFiles
    {
        public void DeleteImages()
        {
            Thread.Sleep(2000);
            DirectoryInfo di = new DirectoryInfo("C:\\HPE_Tasks\\Multithreading_FileApp\\Images\\");
            FileInfo[] fiArr = di.GetFiles();
            int count = 0;
            foreach (FileInfo file in fiArr)
            {
                if (file.Length > 100000)
                {
                    file.Delete();
                    count += 1;
                }
            }
            Console.WriteLine("{0} Images more than 100kb deleted.",count);
        }
        public void DeleteText()
        {
            Thread.Sleep(3000);
            DirectoryInfo di = new DirectoryInfo("C:\\HPE_Tasks\\Multithreading_FileApp\\Text\\");
            FileInfo[] fiArr = di.GetFiles();
            int count = 0;
            foreach (FileInfo file in fiArr)
            {
                if (file.Length > 5000)
                {
                    file.Delete();
                    count += 1;
                }
            }
            Console.WriteLine("{0} Text files more than 5kb deleted.",count);
        }

        public void DeleteVideos()
        {
            Thread.Sleep(4000);
            DirectoryInfo di = new DirectoryInfo("C:\\HPE_Tasks\\Multithreading_FileApp\\Videos\\");
            FileInfo[] fiArr = di.GetFiles();
            int count = 0;
            foreach (FileInfo file in fiArr)
            {
                if (file.Length > 1000000)
                {
                    file.Delete();
                    count += 1;
                }
            }
            Console.WriteLine("{0} Videos more than 1mb deleted.", count);
        }
    }
}
