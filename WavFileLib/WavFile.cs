using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileLib;

namespace WavFileLib
{
    public class WavFile : File
    {
        public override void FileName(string name)
        {
            Console.WriteLine("文件名[{0}]是WAV视频文件，使用视频播放器打开", name);
        }
    }
}
