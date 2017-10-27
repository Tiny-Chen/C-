using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _24文件路径提取
{
    class Program
    {
        static void Main(string[] args)
        {
            //找规律
            //C:\123\456\789.TXT
            //C:\123.TXT
            //分组说明           12                  34  5         从左边第1个左括号开始数，共5组
            string regex = @"(([a-zA-Z]:).*\\)((.+)(\..+))";
            //([a-zA-Z]:)盘符
            //(([a-zA-Z].:).*\\)文件路径
            //(.+)文件名
            //(\..+)扩展名
            while (true)
            {
                Console.WriteLine("请输入文件扩展名");
                string input = Console.ReadLine();

                Match m = Regex.Match(input, regex);

                Console.WriteLine("文件所在的盘符是：{0}", m.Groups[2].Value);
                Console.WriteLine("文件的路径是{0}", m.Groups[1].Value);
                Console.WriteLine("文件名是{0}", m.Groups[3].Value);
                Console.WriteLine("\r\n\r\n");
                Console.ReadKey();
            }
           
        }
    }
}
