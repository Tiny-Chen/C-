using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _23贪婪模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //正则表达式默认匹配贪婪模式，就是匹配较多的内容,权重分配是区分大小的
            string str = "1234567890";
            string regex = @"(\d+)(\d+)(\d+)";

            Match mc = Regex.Match(str,regex);

            //Groups[0]=12345678;---------权重分配
            //Groups[1]=9;
            //Groups[2]=0;

            //取消的方式
            string regexs = @"(\d+?)(\d+)(\d+)";

            //Groups[0]=1;-------第1组取消贪婪后
            //Groups[1]=23456789;--权重分配
            //Groups[2]=0;
        }
    }
}
