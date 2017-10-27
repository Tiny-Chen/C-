using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMp3Class
{
    public class UMp3:UsbComponentClass.UsbComponent
    {
        public override void Inseter()
        {
            Console.WriteLine("Mp3可以使用了");
        }
    }
}
