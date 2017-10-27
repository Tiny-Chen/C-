using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MpegFileLib;
using TxtFileLib;
using WavFileLib;
using File = FileLib.File;

namespace FactoryLib
{
    /// <summary>
    /// 工厂类库
    /// </summary>
    public class Factory
    {
        public static File FileSelet(string type)
        {
            //提取文件扩展名
            string pathName = Path.GetExtension(type).ToLower();
            switch (pathName)
            {
                case "txt":
                case ".txt": return new TxtFile();
                case ".wav":
                case "wav":return new WavFile();
                case ".mpeg":
                case "mpeg":return new MpegFile();
                    default: return null;
            }
        }
    }
}
