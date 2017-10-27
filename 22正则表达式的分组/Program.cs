using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _22正则表达式的分组
{
    class Program
    {
        static void Main(string[] args)
        {
            //案例，从百家姓中，提取所有姓氏

            //不分组的提取法
            /*
            string str = File.ReadAllText("百家姓.txt", Encoding.Default);

            MatchCollection mc = Regex.Matches(str, @"〔.+〕");

            int i = 0;
            foreach (Match m in mc)
            {
                string s = m.Value.Replace("〔", "").Replace("〕", "");
                Console.Write("{0}.{1}\t",i++,s);
                //每打印5个就换行，因为超出一定数后，控制台会换页
                if (i % 5 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
            */

            //使用分组
            string str = File.ReadAllText("百家姓.txt", Encoding.Default);

            //正则表达式中，用括号分组，这样就不会出现后面还要替换一些信息的麻烦，只提取出我们需要的内容，组的信息在Group中
            MatchCollection mc = Regex.Matches(str, @"〔(.+)〕");

            int i = 0;
            foreach (Match m in mc)
            {
                //通过groups[组号]来访问所需的值，从左括号（ 开始数，从1开始，因为0是字符串本身即，m.value==m.groups[0].value
                string s = m.Groups[1].Value;
                Console.Write("{0}.{1}\t", i++, s);
                //每打印5个就换行，因为超出一定数后，控制台会换页
                if (i % 5 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
