using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03多态简单工厂
{
    class Program
    {
        static void Main(string[] args)
        {
            //用户需求
            Console.WriteLine("请输入设备的序号");
            Console.WriteLine("1,U盘；2，MP3");
            int num = int.Parse(Console.ReadLine());

            //创建父类对象
            UsbComponent usb = Factory.usb(num);

            if (usb != null)
            {
                usb.Inseter();
            }
            else
            {
                Console.WriteLine("请选择正确的设备序号");
            }
            

            Console.ReadKey();
        }
    }
}
