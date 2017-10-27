using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03多态简单工厂
{
    /// <summary>
    /// USB设备产品父类
    /// </summary>
    class UsbComponent
    {
        public virtual void Inseter()
        {
            Console.WriteLine("USB设备父类");
        }
    }
}
