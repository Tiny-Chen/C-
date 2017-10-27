using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04接口实现多态
{
    class CC2 : CC1
    {
        //当接口没有重名方法的情况下可以使用隐式实现
        public override void Func()
        {
            Console.WriteLine("CC2");
        }
    }
}
