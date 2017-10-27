using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06StringBuilde
{
    class Program
    {
        static void Main(string[] args)
        {
            //读取数据文件
            string[] lines = File.ReadAllLines("menu.txt", Encoding.Default);
            //解析文件,拼接
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < lines.Length; i++)
            {
                //主菜单项分割出列表名称
                string[] temps = lines[i].Split(':');
                //一级菜单名称
                string mainName = temps[0];
                sb.AppendLine("<li><span><a href=\"#\">" + mainName + "</a><b class =\"mark\"></b></span>");
                sb.AppendLine("<\t<div><ul>");
                //解析一级菜单中的二级菜单
                //string[] tts = temps[1].Split(',');
                //foreach (string item in tts)
                //{
                //    sb.AppendFormat("\t\t<li>{0}</li>\r\n", item);
                //}
                sb.AppendFormat("<li>{0}</li>", temps[1].Replace(",", "</li>\r\n<li>"));

                sb.AppendLine("\t</ul></div>");
                sb.AppendLine("</li>");

                //读取模板
                string html = File.ReadAllText("t.html", Encoding.UTF8);

                //替换模板中的坑
                html = html.Replace("@name", ".net技术").Replace("@list", sb.ToString());
                //写入
                File.WriteAllText("Dotnet.html",html,Encoding.UTF8);
            }
        }
    }
}
