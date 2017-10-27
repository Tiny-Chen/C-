using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace 字符串练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 练习一将字符串反向输出

            //Console.WriteLine("请输入字符");
            //string str = Console.ReadLine();
            //string newStr=MyReverseString(str);
            //Console.WriteLine(newStr);
            //Console.ReadKey();
            #endregion
            #region 练习二，将语句的单词反向输出
            //string str = "I love you";
            ////分割
            //string[] s1 = str.Split("  ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            //for (int i = 0; i < s1.Length; i++)
            //{
            //    s1[i] = MyReverseString(s1[i]);
            //}
            //string newStr = string.Join(" ",s1);
            //Console.WriteLine(newStr);
            //Console.ReadKey();
            #endregion

            #region 练习三将2017年10月10日中的年月日取出来
            //练习三将2017年10月10日中的年月日取出来
            string date = "2017年10月10日";
            #region MyRegion
            //string date2 = date1.Replace("年", "-").Replace("月", "-").Replace("日", "-");
            //string[] str = date2.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            //for (int i = 0; i < str.Length; i++)
            //{
            //    Console.WriteLine(str[i]);
            //} 
            #endregion

            int yearIndex = date.IndexOf('年');
            int monthIndex = date.IndexOf('月');
            int dayIndex = date.IndexOf('日');

            string year = date.Substring(0, yearIndex);
            string month = date.Substring(yearIndex + 1, monthIndex - yearIndex - 1);
            string day = date.Substring(monthIndex + 1, dayIndex - monthIndex - 1);

            Console.WriteLine(year);
            Console.WriteLine(month);
            Console.WriteLine(day);
            Console.ReadKey();
            #endregion

            #region 练习四把CVS通信录中的信息读取出来
            //把CVS通信录中的信息读取出来
            //string[] lines = File.ReadAllLines("1.cvs", Encoding.UTF8);
            //foreach (string item in lines)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey(); 
            #endregion

            #region 练习五123---456--123---7878-3-----34-----6把多余的线变成一个-
            //练习五123---456--123---7878-3-----34-----6把多余的线变成一个-
            //string str = "123---456--123---7878-3-----34-----6";
            //string[] str1 = str.Split(new char[] {'-'}, StringSplitOptions.RemoveEmptyEntries);
            //string str2 = string.Join("-",str1);
            //Console.WriteLine(str2);
            //Console.ReadKey(); 
            #endregion

            #region 练习六从文件路径中提取出文件名
            //从文件路径中提取出文件名
            //string path = @"c:\12\456\789.txt";
            //string name = Path.GetFileName(path);
            //Console.WriteLine(name);
            //Console.ReadKey(); 
            #endregion

            #region 练习七解释IP地址
            //练习七解释IP地址192.168.0.1[prot=21,type=ftp]成字符串Ip地址为XXXX的服务器XXX端口提供XXX服务；
            //string ipadd = "192.168.0.1[prot=21,type =ftp]";
            ////分割地址和端口
            //string[] ipAdds = ipadd.Split(new char[] {'[', ']'}, StringSplitOptions.RemoveEmptyEntries);
            //string[] IPprot = ipAdds[1].Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries);
            ////分割端口
            //string[] prot = IPprot[0].Split(new char[] {'='}, StringSplitOptions.RemoveEmptyEntries);
            ////分割服务
            //string[] servers = IPprot[1].Split(new char[] {'='}, StringSplitOptions.RemoveEmptyEntries);

            //Console.WriteLine("Ip地址为{0}的服务器{1}端口提供{2}服务",ipAdds[0],prot[1],servers[1]);
            //Console.ReadKey(); 
            #endregion

            //求gongzi文件中员工最高工资、最低工资、平均工资

            //姓名:张三，工资：1000；
            //姓名:李四，工资：2000；
            //姓名：王五，工资：3000；
            //姓名：赵六，工资：4000；

            //string[] lines = File.ReadAllLines("gz.txt", Encoding.UTF8);
            //Dictionary<int,int> gongzi = new Dictionary<int, int>();
            //Dictionary<int, string> name = new Dictionary<int, string>();
            //Dictionary<string,int>gonzi1 = new Dictionary<string, int>();

            //for (int i = 0; i < lines.Length; i++)
            //{
            //    //分割姓名与工资
            //    string[] str1 = lines[i].Split(new char[] { '：', '，', '；' }, StringSplitOptions.RemoveEmptyEntries);
            //    //添加到集合中
            //    gongzi.Add(i,int.Parse(str1[3]));
            //    name.Add(i,str1[1]);
            //    gonzi1.Add(str1[1],int.Parse(str1[3]));
            //}
            //int max = gongzi[0];
            //int min = gongzi[0];
            //int maxNameID = 0;
            //int minNameID = 0;
            //int sum = 0;

            //for (int i = 0; i < gongzi.Count; i++)
            //{
            //    if (max < gongzi[1])
            //    {
            //        max = gongzi[i];
            //    }
            //    if (min > gongzi[i])
            //    {
            //        min = gongzi[i];
            //    }
            //    sum += gongzi[i];
            //}
            //int avg = sum / gongzi.Count;
            //foreach (KeyValuePair<int, int> item in gongzi)
            //{
            //    if (item.Value.Equals(max))
            //    {
            //        maxNameID = item.Key;
            //    }
            //    if (item.Value.Equals(min))
            //    {
            //        minNameID = item.Key;
            //    }
            //}
            //Console.WriteLine("最高工资为{0}{1}，最低工资为{2}{3}，平均工资为{4}", name[maxNameID], max, name[minNameID], min, avg);
            //Console.ReadKey();
        }
        /// <summary>
        /// 反转字符串
        /// </summary>
        /// <param name="str">需反转的字符</param>
        /// <returns></returns>
        public static string MyReverseString(string str)
        {
           char[] str1 = str.ToCharArray();
            for (int i = 0; i < str1.Length / 2; i++)
            {
                char temp = str1[i];
                str1[i] = str1[str1.Length - 1 - i];
                str1[str1.Length - 1 - i] = temp;
            }
            return new string(str1);
        }
    }
}
