using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _32泛型委托
{
    class MyClass
    {
        public string Name { get; set; }

        public void SayHello()
        {
            Console.WriteLine("你好，{0}", Name);
        }
    }
    class Preson
    {
        public string Name { get; set; }

        public void SayHello()
        {
            Console.WriteLine("人民，{0}", Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //C#默认的泛型委托---不需要去定义delegate
            //Func系：有返回值的泛型委托
            //Action系：无返回值的泛型委托

            //示例Action
            Action ac;
            ac = new MyClass(){Name = "张三"}.SayHello;
            ac();

            //泛型的使用
            Action<Preson, MyClass> asc;
            asc = (a, b) => {a.SayHello();b.SayHello(); };
            asc(new Preson(){Name = "你好"}, new MyClass(){Name = "Myclass"});

            //示例Func
            Func<string, string,int> cmp = string.Compare;
            cmp = (a, b) => { return a.Length - b.Length; };
            int num = cmp("123", "12");

            Console.ReadKey();
        }
    }
}
