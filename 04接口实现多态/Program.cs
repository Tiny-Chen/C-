using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04接口实现多态
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建接口对象给子类---多态
           // Iindterface idf = new CC2();
           // idf.Func();
            //Console.ReadKey();

            II i1 = new CC3();//------------看是哪个对象，那么实现的方法是其对应的方法---显示实现接口-------多态
            i1.Func();
            Iindterface idf = new CC3();
            idf.Func();
        }
    }
}
