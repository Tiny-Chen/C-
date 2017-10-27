using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileLib;

namespace MpegFileLib
{
    public class MpegFile : File
    {
        public override void FileName(string name)
        {
            Console.WriteLine("文件名[{0}]是MPEG视频文件，使用视频播放器打开",name);
        }
    }
}
