using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08编码Encoding
{
    class Program
    {
        static void Main(string[] args)
        {
            //字符集
            /*
            Encoding.Default;
            Encoding.UTF8;
            Encoding.Unicode;
            Encoding.BigEndianUnicode;
            */

           // 数字转换成十六进制的形式--x2
            //for (int i = 11; i < 36; i++)
            //{
            //    Console.WriteLine(i.ToString("x2"));
            //}
            //Console.ReadKey();

            //在处理文件中的应用

        }

        /// <summary>
        /// 根据文件名读取文件
        /// </summary>
        /// <param name="fileName">文件名</param>
        /// <returns></returns>
        private static string GetCountentFromFile(string fileName)
        {
            if (fileName == null)
            {
                throw new Exception("文件名不允许为空");
            }
            return File.ReadAllText(fileName, GetEncoding(fileName));
        }

        /// <summary>
        /// 根据文件名得到文件编码
        /// </summary>
        /// <param name="file">文件名</param>
        /// <returns></returns>
        private static Encoding GetEncoding(string file)
        {
            /*
             * 读取三个字节，编码除ansi之外均为1个字符2个字节
             * 如果前两个字节数据为ff fe则为unicode格式
             * 如果前三个字节为ef bb df则为utf-8格式
             * 如果前两个字节为fe ff则为unicode Big Endian格式
             */
             //定义字符
            int firstChar;
            Encoding encoding;
            //读取文件
            using (FileStream filetemp = new FileStream(file,FileMode.Open,FileAccess.Read))
            {
                firstChar = filetemp.ReadByte();
            }
            //判断编码格式
            switch (firstChar)
            {
                case 0xff:encoding = Encoding.Unicode;break;
                case 0xfe:encoding = Encoding.BigEndianUnicode;break;
                case 0xef:encoding = Encoding.UTF8;break;
                    default:encoding=Encoding.Default;break;
            }
            return encoding;
        }
    }
}
