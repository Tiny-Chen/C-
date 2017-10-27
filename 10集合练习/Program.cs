using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _10集合练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习一
            //两个（List）集合{ “a”,“b”,“c”,“d”,“e”}和{ “d”, “e”, “f”, “g”, “h” }
            //把这两个集合去除重复项合并成一个
            #region MyRegion
            /*
               List<string> str0 =new List<string>("a,b,c,d,e".Split(','));
                List<string> str1 =new List<string>(){"a","b","c","d","e"};
                List<string> str2 = new List<string>() { "d", "e", "f", "g", "h" };
              //方法一
                List<string> str3 = new List<string>();
            //str3.AddRange(str1);
            //str3.AddRange(str2);
            // for (int i = 0; i < str3.Count; i++)
            // {
            //     for (int j = i+1; j < str3.Count; j++)
            //     {
            //         if (str3[i].Equals(str3[j]))
            //         {
            //             str3.RemoveAt(j);
            //         }
            //     }
            // }

            //方法二
            //遍历一个集合，将这个集合中，不在另一个集合中的项添加进去
            //for (int i = 0; i < str2.Count; i++)
            //{
            //    if (!str1.Contains(str2[i]))
            //    {
            //        str1.Add(str2[i]);
            //    }
            //}

            //方法三，使用HashSet<T>的集合
            //HashSet<T>的特点是，所有元素都是维一的。
            str1.AddRange(str2);
            HashSet<string> h = new HashSet<string>(str1);
           // h.ToString();
             */

            #endregion

            //练习二
            //随机生成10个1-100之间的数放到List中，要求这10个数不能重复，并且都是偶数(添加10次，可能循环很多次。)
            #region 练习二
            //方法一
            //List<int> num = new List<int>();
            //Random r = new Random();
            //num = GetListNum(num, r);
            //foreach (int item in num)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();

            //方法二----简单
            //Random r = new Random();

            //r.Next();//创建一般的随机数
            //r.Next(10);//创建从0到10的随机数，不含10
            //r.Next(5, 10);//创建指定范围的随机数

            //List<int > list = new List<int>();
            //while (list.Count<10)
            //{
            //    int num = r.Next(1, 101);
            //    //限制条件--数字不重复，而且都是偶数
            //    if (!list.Contains(num) && num % 2 == 0)
            //    {
            //        list.Add(num);
            //    }
            //} 
            #endregion

            //练习三
            //创建1个由0-9组成的随机数，要求数字长度为10并且每1个数字都不重复
            #region MyRegion
            // Random r = new Random();
            // List<string> list = new List<string>();
            // while (list.Count<10)
            // {
            //     int num = r.Next(0, 10);
            //     if (!list.Contains(num.ToString()))
            //     {
            //         list.Add(num.ToString());
            //     }
            // }
            // int num2 =string.Join(" ",list);
            // Console.WriteLine(num2);
            // Console.ReadKey(); 
            #endregion

            //练习四
            //随机创建1个字母，填充到一个长度为10的数组中，要求所有字母不重复
            //随机数据转换为字母
            #region MyRegion
            /*
              Random r = new Random();
               //在ASCII中，字母是从97开始，共26个
               List<char>list = new List<char>();
               while (list.Count<10)
               {
                   int num = r.Next(26*2);//包含大小写*2
                   //char str = (char)('a'+num);//因为a=97不好记
                   char str;
                   //if (num > 25)
                   //{
                   //    //大写字母
                   //    str = (char) ('A' + (num-26));
                   //}
                   //else
                   //{
                   //    //小写字母
                   //    str = (char) ('a' + num);
                   //}
                   str = (char)(num > 25 ? ('A' + (num - 26)) : ('a' + num));

                   if (!list.Contains(str))
                   {
                       list.Add(str);
                   }
               }
               Console.WriteLine(string.Concat(list));
              Console.ReadKey();
              */
            #endregion

            //练习五
            //分开奇偶数，用泛型实现
            #region MyRegion
            //string str = "12345678";
            //List<string> list1 = new List<string>();
            //List<string>list2 = new List<string>();
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (str[i] % 2 == 0)
            //    {
            //        list2.Add(str[i].ToString());
            //    }
            //    else
            //    {
            //        list1.Add(str[i].ToString());
            //    }
            //}
            //list1.AddRange(list2);
            //Console.WriteLine(string.Join(" ",list1));
            //Console.ReadKey(); 
            #endregion

            //练习六，数字转换
            #region MyRegion
            //把123转换为壹贰叁
            //string str = "1壹 2贰 3叁 4肆 5伍 6陆 7柒 8捌 9玖 0零";
            ////切割成每一个数组元素
            //string[] temp = str.Split(' ');
            //Dictionary<char, char> dic = new Dictionary<char, char>();
            ////添加到集合
            //for (int i = 0; i < temp.Length; i++)
            //{
            //    string num = temp[i];
            //    dic.Add(num[0],num[1]);
            //}
            //Console.WriteLine("请输入");
            //char[] input = Console.ReadLine().ToCharArray();
            //for (int i = 0; i < input.Length; i++)
            //{
            //    //判断是否存在该键
            //    if (dic.ContainsKey(input[i]))
            //    {
            //        //存在，把该键对应的值给数组
            //        input[i] = dic[input[i]];
            //    }
            //}
            //Console.WriteLine(new string(input));
            //Console.ReadKey(); 
            #endregion

            //练习七
            //计算每个字母出现的次数，Welcome to Chinaworld
            Console.WriteLine("请输入一句话");
            char[] input = Console.ReadLine().ToCharArray();
            Dictionary<char,int> dic = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                //如果包含，那么所在键对应的值++
                if (dic.ContainsKey(input[i]))
                {
                    dic[input[i]]++;
                }
                else
                {
                    //如果不包含，那么添加该键，值初始化为1
                    dic.Add(input[i],1);
                }
            }
            foreach (KeyValuePair<char,int> item in dic)
            {
                Console.WriteLine("字符{0}---出现{1}次",item.Key,item.Value);
            }
            Console.ReadKey();
        }
        /// <summary>
        /// 随机生成10个1-100之间的元素的集合
        /// </summary>
        /// <param name="num">集合</param>
        /// <param name="r">随机数</param>
        /// <returns>生成好的集合</returns>
        private static List<int> GetListNum(List<int> num, Random r)
        {
            for (int i = 0; i <10; i++)
            {
                int temp = r.Next(100);
                //把偶数添加到集合中
                if (temp % 2 == 0)
                {
                    num.Add(temp);
                }
            }
            //去除重复
            num = ReMoveNum(num);
            //判断是否够十个数了，否则递归
            if (num.Count <10)
            {
                GetListNum(num, r);
            }
            //移除多余的确保是十个
            if (num.Count > 10)
            {
                num.RemoveRange(10,num.Count-10);
            }
                return num;
        }

        /// <summary>
        /// 去除集合中重复元素的方法
        /// </summary>
        /// <param name="num">需要去除重复的集合</param>
        /// <returns>去除重复后的集合</returns>
        private static List<int> ReMoveNum(List<int> num)
        {
            for (int i = 0; i < num.Count; i++)
            {
                for (int j = i+1; j < num.Count; j++)
                {
                    if (num[i].Equals(num[j]))
                    {
                        num.RemoveAt(j);
                    }
                }
            }
            return num;
        }
    }
}
