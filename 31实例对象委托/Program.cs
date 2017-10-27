using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31实例对象委托
{
    class MyClass
    {
        public string Name { get; set; }

        public void SayHello()
        {
            Console.WriteLine("你好，{0}",Name);
        }
    }

    class Program
    {
        //1、定义委托
        public delegate void MyDelegate();

        static void Main(string[] args)
        {
            //创建实 例
            MyClass mc = new MyClass(){Name = "张三"};

            //声明委托变量

            MyDelegate my = mc.SayHello;

            my();
        }
    }
}
