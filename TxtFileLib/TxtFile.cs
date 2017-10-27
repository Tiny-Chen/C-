using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileLib;

namespace TxtFileLib
{
    public class TxtFile : File
    {
        public override void FileName(string name)
        {
            Console.WriteLine("文件名[{0}]是文本文件，使用文本文件打开", name);
        }
    }
}
