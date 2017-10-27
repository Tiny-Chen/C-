using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27委托计算器案例
{
    public delegate double Cutcal(double d1, double d2);
    class Program
    {
        //第2步，定义委托类型

        static void Main(string[] args)
        {
            Console.WriteLine("请输入第1个数");
            string str1 = Console.ReadLine();
            Console.WriteLine("请输入第2个数");
            string str2 = Console.ReadLine();
            Console.WriteLine("请输入运算符");
            string open = Console.ReadLine();

            //第3部，声明委托变量
            Cutcal MyCutcalDelegate;

            //第4部，授权方法

            MyCutcalDelegate = Fartoy(open);//  根据运算符，返回对应的方法给他

            //第5部，使用委托变量名，调用方法

            if (MyCutcalDelegate != null)
            {
                double res = MyCutcalDelegate(Double.Parse(str1), Double.Parse(str2));
                Console.WriteLine(res);
            }
            Console.ReadKey();
        }

        

        //委托授权方法工厂
        static Cutcal Fartoy(string open)
        {
            switch (open)
            {
                case "+": return Sum;
                case "-": return Sub;
                case "*": return Multi;
                case "/": return Div;
                    default: return null;
            }
        }

        //1、运算方法
        //加
        static double Sum(double d1, double d2)
        {
            return d1 + d2;
        }

        static double Sub(double d1, double d2)
        {
            return d1 - d2;
        }

        static double Multi(double d1, double d2)
        {
            return d1 * d2;
        }

        static double Div(double d1, double d2)
        {
            return d1 / d2;
        }
    }
}
