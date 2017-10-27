using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMouseClass
{
    public class UMouse:UsbComponentClass.UsbComponent
    {
        public override void Inseter()
        {
            Console.WriteLine("鼠标可以使用了");
        }
    }
}
