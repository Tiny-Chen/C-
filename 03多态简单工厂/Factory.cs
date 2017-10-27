using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03多态简单工厂
{
    /// <summary>
    /// 工厂，根据用户需求，给出产品：可封装成DLL，方便升级维护
    /// </summary>
    class Factory
    {
        /// <summary>
        /// USB产品
        /// </summary>
        /// <param name="number">用户选择序号</param>
        /// <returns></returns>
        public static UsbComponent usb(int number)
        {
            switch (number)
            {
                case 1:return new UDisk();
                   
                case 2:return new UMp3();

                default: return null;
            }
        }
    }
}
