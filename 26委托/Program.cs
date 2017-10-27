using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _26委托
{
    class Program
    {
        //第二步，准备委托类型---public delegate 返回值类型  委托类型名字(可带参数或不带参数)
        public delegate void MyDelegate();

        static void Main(string[] args)
        {
            //把方法当变量使用
            //五个步骤
            
            //第三步，声明委托变量

            MyDelegate myDelegate;

            //第四步，授权方法或注册方法
            myDelegate = Fuan;

            //第五步，使用委托变量名调用方法

            myDelegate();

            Console.ReadKey();

        }

        //第一步，准备方法
        public static void Fuan()
        {
            Console.WriteLine("我是委托方法");
        }
    }
}
