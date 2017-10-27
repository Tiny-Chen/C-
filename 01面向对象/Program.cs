using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01面向对象
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 5;
            //找个对象
           Calculator cal = new Sum();
            //做事情
            cal.Run();
        }
    }

    
}
