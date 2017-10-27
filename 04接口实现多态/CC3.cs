using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04接口实现多态
{
    class CC3 : II, Iindterface
    {
        //显示式实现接口-----两个接口中具有重名的方法
        void II.Func()
        {
            Console.WriteLine("IIIIII");
            ;
        }

        void Iindterface.Func()
        {
            Console.WriteLine("Ilinderface");
        }
    }
}
