using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09读写流Stream
{
    class Program
    {
        static void Main(string[] args)
        {
            //写流StreamWrite
            #region StreamWrite
            //Console.WriteLine("请输入保存的文件名");
            //string file = Console.ReadLine();
            ////                                                          读取名称、是否追加、编码格式
            //using (StreamWriter write = new StreamWriter(file,true,Encoding.Default))
            //{
            //    //写文本
            //    while (true)
            //    {
            //        //
            //        Console.Write(@"C:\user> ");
            //        string input = Console.ReadLine();
            //        //退出时的判断
            //        if (input.ToLower() == "exit")
            //        {
            //            Console.WriteLine("保存成功");
            //            write.Dispose();
            //            Console.ReadKey();
            //            return;
            //        }
            //        //写入文本
            //        write.WriteLine(input);
            //    }
            //} 
            #endregion

            //读流StreamRead
            using (StreamReader sr = new StreamReader("1.txt",Encoding.Default))
            {
                //接收的字符串
                string str = null;
                int i = 0;
                //循环至读完字符为止
                while ((str = sr.ReadLine())!=null)
                {
                    Console.WriteLine("{0}\t{1}",++i,str);
                }
            }
            Console.ReadKey();
        }
    }
}
