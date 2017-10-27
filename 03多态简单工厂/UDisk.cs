using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03多态简单工厂
{
    class UDisk : UsbComponent
    {
       public override void Inseter()
        {
            Console.WriteLine("插入U盘");
        }
    }
}
