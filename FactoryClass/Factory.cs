using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDiskClass;
using UMouseClass;
using UMp3Class;
using UsbComponentClass;//引用后，导入命名空间

namespace FactoryClass
{
    /// <summary>
    /// 工厂类库
    /// </summary>
    public class Factory
    {
        /// <summary>
        /// 根据用户选择给出产品
        /// </summary>
        /// <param name="number">用户选择序号</param>
        /// <returns></returns>
        public static UsbComponent Usb(int number)
        {
            switch (number)
            {
                case 1:return new UDisk();
                case 2:return new UMouse();
                case 3:return new UMp3();
                    default: return null;
            }
        }
    }
}
