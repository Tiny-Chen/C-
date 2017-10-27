using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11文件合并案例
{
    class Program
    {
        static void Main(string[] args)
        {
            //文件合并就是把文件变成二进制文件进行合并
            //读取的文件
           List<string> froms = new List<string>();
            while (true)
            {
                Console.WriteLine("请输入需要合并的文件，输入OK结束");
                string input = Console.ReadLine();
                if (input=="ok") break;
                else froms.Add(input);
            }
            //保存的问件路径及名称
            Console.WriteLine("请输入保存的路径入名称");
            string fileSave = Console.ReadLine();

            using (FileStream file = new FileStream(fileSave, FileMode.Create, FileAccess.Write))
            {
                //有几个文件需要写循环多少次
                for (int i = 0; i < froms.Count; i++)
                {
                    //将I个文件都写到file中
                    using (FileStream temp = new FileStream(froms[i],FileMode.Open,FileAccess.Read))
                    {
                        //设置缓存
                        byte[] buffer = new byte[1024*1024];
                        //记录读取的字节块数
                        int count = 0;
                        //循环读取和写入
                        while ((count = temp.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            file.Write(buffer,0,count);
                        }
                       
                    }
                }
            }
        }
    }
}
