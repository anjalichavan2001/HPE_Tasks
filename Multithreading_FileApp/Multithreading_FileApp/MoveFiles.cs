using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Multithreading_FileApp
{
    class MoveFiles
    {
        public void Move_files()
        {
            string rootFolderPath = @"C:\HPE_Tasks\Multithreading_FileApp\Files\";
            string imageFolder = @"C:\HPE_Tasks\Multithreading_FileApp\Images\";
            string textFolder = @"C:\HPE_Tasks\Multithreading_FileApp\Text\";
            string videoFolder = @"C:\HPE_Tasks\Multithreading_FileApp\Videos\";
            DirectoryInfo di = new DirectoryInfo("C:\\HPE_Tasks\\Multithreading_FileApp\\Files\\");
            FileInfo[] fiArr = di.GetFiles();
            foreach (FileInfo file in fiArr)
            {
                if(file.Extension == ".txt")
                    File.Move(rootFolderPath + file,textFolder + file );
                if (file.Extension == ".jpg")
                    File.Move(rootFolderPath + file, imageFolder + file);
                if (file.Extension == ".mp4")
                    File.Move(rootFolderPath + file, videoFolder + file);
            }
        }
    }
}
