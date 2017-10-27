using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20匿名方法
{
    class Program
    {
        public delegate int GetSum(int max, int min);
        static void Main(string[] args)
        {
            //语法
            // 委托类型   委托变量 = delegate （类型  参数列表）{  方法体 }；

            //普通匿名委托方法
            // GetSum getSum = delegate (int max, int min)
            // {
            //     int sum = 0;
            //     for (int i = min; i <= max; i++)
            //     {
            //         sum += i;
            //     }
            //     return sum;
            // };

            //使用Lambda表达式表示
            GetSum getSum = (a, b) =>
            {
                int sum = 0;
                for (int i = a; i <= b; i++)
                {
                    sum += a;
                }
                return sum;
            };

            int res = getSum(1, 100);

          
            
        }
    }
}
