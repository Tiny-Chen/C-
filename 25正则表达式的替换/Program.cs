using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _25正则表达式的替换
{
    class Program
    {
        static void Main(string[] args)
        {
            //一般基础的替换
            //string str = "123-----456-----abc------";

            //string res = Regex.Replace(str, @"-+", "+");//表达式中，减号至少出现1次的，替换成+

            //Console.WriteLine(res);
            //Console.ReadKey();

            //引用替换
            string html = "如果你想搜索一些内容请点击http://www.baidu.com，如果你想读书，请上http://www.csdn.cn";
            //把http://www.baidu.com替换<a href="http://www.baidu.com"></a>，这样文本中的网址就可以点击了
            //找规律，前面http,后面，.com|.cn|.orc等
            //http.+?\.[a-zA-Z]
            //使用$可以提取分组替换的内容
           string res = Regex.Replace(html, @"http.+?[a-zA-Z]+\.(com|cn)", "<a href=\"$0\">$0</a>");
            File.WriteAllText("1.html", res, Encoding.UTF8);
            Console.ReadKey();
        }
    }
}
