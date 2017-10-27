using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03多态简单工厂
{
    class UMp3:UsbComponent
    {
        public override void Inseter()
        {
            Console.WriteLine("插入MP3");
        }
    }
}
