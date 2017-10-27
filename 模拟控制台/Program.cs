using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryLib;
using FileLib;

namespace 模拟控制台
{
    class Program
    {
        static void Main(string[] args)
        {
            //主程序---创建文件名父类对象-----工厂生产文件名------根据选择返回子对象------调用方法
            Console.WriteLine("请输入文件名,txt,wav,mpeg");
            string name = Console.ReadLine();

            File file = Factory.FileSelet(name);

            if (file != null)
            {
                file.FileName(name);
            }
            else
            {
                Console.WriteLine("指定文件不存在");
            }
            Console.ReadKey();
        }
    }
}
