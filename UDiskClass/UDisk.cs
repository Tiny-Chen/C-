using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDiskClass
{
    /// <summary>
    /// U盘产品类库
    /// </summary>
    public class UDisk:UsbComponentClass.UsbComponent
    {
        public override void Inseter()
        {
            Console.WriteLine("U盘可以使用了");
        }
    }
}
