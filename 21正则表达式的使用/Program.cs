using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _21正则表达式的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            //正则表达式：1个用于匹配、提取、替换用的包含元字符的字符串；
            //示例：“中国.+”；其中.和+就是元字符，整个合起来就是正则表达式
            //.表示任意的1个非换行字符，只是1个
            //+ 紧跟在+前面的字符出现任意次，但至少有1次
            //示例可配出：中国人民，中国万岁等等，只要网页中出现了中国两个字的地方都能根据元字符条件匹配出来

            //示例：提取邮箱名
            //使用webclient类来记录网页
            WebClient wc = new WebClient();
            //转码
            wc.Encoding = Encoding.UTF8;
            //下载资源----路径
            string html = wc.DownloadString("http://192.168.27.69:8080/大家留下email交友吧_email_天涯社区.htm");
            //1，找规律，查看网页源代码，这些邮箱名称有什么特点，415717100@qq.com;tiny-chen@qq.com;
            //我们可以看到有三部分组成，@前后两部分，.com是一部分，每部分组成是数字、字母、横线等
            //设置正则表达式
            string regex = @"[a-zA-Z0-9\-\._]+@[a-zA-Z0-9\-]+(\.[a-zA-Z0-9]+)+";
            //里面的\表示转义
            //[a-zA-Z0-9\-\._]---邮箱前面部分的组成,中括号表示集合,可以匹配到里面的任意1个字符
            //[a-zA-Z0-9\-]----@后面的部分,中括号表示集合，但要注意，必须按照asnc码的排列大小顺序来填，不然不起作用
            //(\.[a-zA-Z0-9]+)----.com或.cn等等，用小括号是出现多次

            //通过迭代使用正则表达式来匹配网页中的内容，这里返回的其实是一个集中，把匹配到的内容存到里面
            MatchCollection mc = Regex.Matches(html,regex);

            foreach (Match m in mc)
            {
                //Match:是查询到的结果字符串和其他信息对象

                Console.WriteLine(m.Value);
                
            }

        }
    }
}
