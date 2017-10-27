using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30多播委托
{
    class Program
    {
        public delegate void MyDelegate();
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            MyDelegate md;
            //带返回值的多播委托，把返回值添加到列表中，因为多播委托中，返回值是最后那个方法的返回值 
            md = ()=>list.Add(Func1());
            md += Func2;
            md += Func3;
            md += () => Console.WriteLine("我是最后1个");
            //移除
            md -= Func3;
        }

        static int Func1()
        {
            Console.WriteLine("func1");
            return 1;
        }
        static void Func2()
        {
            Console.WriteLine("func2");
            
        }
        static void Func3()
        {
            Console.WriteLine("func3");
        
        }
    }
}
