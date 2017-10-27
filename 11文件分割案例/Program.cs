using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11文件分割案例
{
    class Program
    {
        static void Main(string[] args)
        {
            //在文件上传下载时，使用到文件分割，按缓存大小进行下载和合并

            //1、提示用户输入文件名
            //2、保存名，一般使用文件名+后缀，注意有序号
            //3、计算每个文件要读多少字节（根据分割多少个文件来计算），注意一般向上取整1.1--2math.ceiling()
            //4、利用循环或分步骤写文件

            //提示用户输入文件名
            Console.WriteLine("请输入文件名");
            string file = Console.ReadLine();

            using (FileStream f = new FileStream(file,FileMode.Open,FileAccess.Read))
            {
                //分割的字节流长度，分割成2个
              int maxsize =(int) Math.Ceiling(f.Length / 2*1.0);//因为是double，所以要*1.0;
                //分割写入1-------------------------------------注意路径添加序号
                using (FileStream f1 = new FileStream(file+".1",FileMode.Create,FileAccess.Write))
                {
                    //设置缓存
                    byte[]buffer = new byte[1024*1024];

                    int total = 0;//用于计算读到多少退出分割
                    int count = 0;//用于获取读了多少
                    //循环去读取
                    while ((count=f.Read(buffer,0,buffer.Length))>0)
                    {
                        f1.Write(buffer,0,count);
                        total += count;
                        //如果读取的值 大于分割的大小，那么停止分割
                        if (total > maxsize)
                        {
                            break;
                        }
                    }
                }
                //分割写入2
                using (FileStream f1 = new FileStream(file + ".2", FileMode.Create, FileAccess.Write))
                {
                    //设置缓存
                    byte[] buffer = new byte[1024 * 1024];

                    int total = 0;
                    int count = 0;//用于获取读了多少
                    while ((count = f.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        f1.Write(buffer, 0, count);
                        total += count;
                        //如果读取的值 大于分割的大小，那么停止分割
                        if (total > maxsize)
                        {
                            break;
                        }
                    }
                }
            }
        }
    }
}
